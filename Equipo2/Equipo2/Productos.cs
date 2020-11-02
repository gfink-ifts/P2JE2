using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Equipo2
{
    public partial class Productos : Form
    {
        //INICIO CONEXION
        SqlConnection conexion;

        public void Abrir()
        {
            conexion = new SqlConnection();
            conexion.ConnectionString = @"Integrated Security=SSPI;Initial Catalog=TiendaInformatica;Data Source=HPMINI";
            conexion.Open();
        }

        public void Cerrar()
        {
            conexion.Close();
            conexion.Dispose();
            conexion = null;
            GC.Collect();
        }

        //FIN CONEXION



        public Productos()
        {
            InitializeComponent();
            LlenarComboTipo();
            LlenarComboProductos();
            IniciarlizarFormularios();
        }

        private void button_tipoProducto_Click(object sender, EventArgs e)
        {
            Tipo_Producto form = new Tipo_Producto();
            form.Show();
        }

        private void button_cerrar_Click(object sender, EventArgs e)
        {
            Close();
            GC.Collect();
        }

        private void button_actualizar_Click(object sender, EventArgs e)
        {
            string descripcion = "";
            int cantidad = 0;
            float precio = 0;
            int idprod = -1;

            if (VerificarTextbox())
            {
                if (checkBox_modificarProducto.Checked)
                {
                    descripcion = textBox_descripcion.Text;
                    cantidad = int.Parse(textBox_cantidad.Text);
                    precio = float.Parse(textBox_precio.Text);
                    idprod = int.Parse(comboBox_Producto.SelectedValue.ToString());
                    int idtipo = int.Parse(comboBox_tipo.SelectedValue.ToString());
                    if (InsertarRegistro(descripcion, cantidad, precio, idprod, idtipo))
                    {
                        MessageBox.Show("Alta Exitosa.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LlenarComboTipo();
                        LlenarComboProductos();
                        IniciarlizarFormularios();
                        LlenarGrilla();
                    }
                    else {
                        MessageBox.Show("Error en carga.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LlenarComboTipo();
                        LlenarComboProductos();
                        IniciarlizarFormularios();
                        LlenarGrilla();
                    }

                }
                else {
                    descripcion = textBox_descripcion.Text;
                    cantidad = int.Parse(textBox_cantidad.Text);
                    precio = float.Parse(textBox_precio.Text);
                    int idtipo = int.Parse(comboBox_tipo.SelectedValue.ToString());
                    if (InsertarRegistro(descripcion, cantidad, precio, idprod, idtipo))
                    {
                        MessageBox.Show("Alta Exitosa.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LlenarComboTipo();
                        LlenarComboProductos();
                        IniciarlizarFormularios();
                        LlenarGrilla();
                    }
                    else
                    {
                        MessageBox.Show("Error en carga.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LlenarComboTipo();
                        LlenarComboProductos();
                        IniciarlizarFormularios();
                        LlenarGrilla();
                    }

                }

            }
            else {
                MessageBox.Show("Error en los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool InsertarRegistro(string descripcion, int cantidad, float precio, int idProd, int idTipo) {
            SqlCommand comando;

            if (idProd == -1)
            {
                string insertar = "insert into productos (descripcion,idtipo,cantidad,precio) " +
                    "values (@descripcion,@idtipo,@cantidad,@precio)";
                Abrir();
                comando = new SqlCommand(insertar, conexion);
                comando.Parameters.AddWithValue("@descripcion", descripcion);
                comando.Parameters.AddWithValue("@idtipo", idTipo);
                comando.Parameters.AddWithValue("@cantidad", cantidad);
                comando.Parameters.AddWithValue("@precio", precio);

                int resultado = comando.ExecuteNonQuery();
                Cerrar();
                if (resultado == 1)
                {
                    return true;
                }
                else {
                    return false;
                }
                

            }
            else
            {
                string actualizacion = "update productos set descripcion=@descripcion, idtipo=@idTipo, cantidad=@cantidad, precio=@precio" +
                    " where idProducto = @idProd";
                Abrir();
                comando = new SqlCommand(actualizacion, conexion);
                comando.Parameters.AddWithValue("@descripcion", descripcion);
                comando.Parameters.AddWithValue("@cantidad", cantidad);
                comando.Parameters.AddWithValue("@precio", precio);
                comando.Parameters.AddWithValue("@idProd", idProd);
                comando.Parameters.AddWithValue("@idTipo", idTipo);

                int resultado = comando.ExecuteNonQuery();
                Cerrar();
                if (resultado == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

        private bool VerificarTextbox() {

            int cantidad = 0;
            float precio = 0;

            if (!string.IsNullOrWhiteSpace(textBox_descripcion.Text) && int.TryParse(textBox_cantidad.Text, out cantidad) && float.TryParse(textBox_precio.Text, out precio))
            {
                return true;
            }
            else {
                return false;
            }
        }


        private void LlenarComboTipo()
        {

            SqlDataAdapter da;
            DataTable dt = new DataTable();

            string consulta = "SELECT idTipo, descripcion FROM tipo_producto";
            Abrir();
            da = new SqlDataAdapter(consulta, conexion);
            da.Fill(dt);
            Cerrar();
            comboBox_tipo.DataSource = dt;
            comboBox_tipo.ValueMember = "idtipo";
            comboBox_tipo.DisplayMember = "descripcion";
        }

        private void LlenarComboProductos() {

            SqlDataAdapter da;
            DataTable dt = new DataTable();

            string consulta = "SELECT idProducto, descripcion FROM productos";
            Abrir();
            da = new SqlDataAdapter(consulta, conexion);
            da.Fill(dt);
            Cerrar();
            comboBox_Producto.DataSource = dt;
            comboBox_Producto.ValueMember = "idProducto";
            comboBox_Producto.DisplayMember = "descripcion";
        }

        private void LlenarGrilla() {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string consulta = "select tp.descripcion as Tipo, p.descripcion as Descripcion, p.cantidad, p.precio " +
                "from Productos as p, Tipo_Producto as tp " +
                "where p.idTipo = tp.idTipo";
            Abrir();
            da = new SqlDataAdapter(consulta, conexion);
            da.Fill(dt);
            Cerrar();
            dataGridView_productos.DataSource = dt;

        }

        private void IniciarlizarFormularios() {
            comboBox_Producto.Enabled = false;
            textBox_cantidad.Text = "";
            textBox_descripcion.Text = "";
            textBox_precio.Text = "";

        }

        private void checkBox_modificarProducto_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_modificarProducto.Checked)
            {
                comboBox_Producto.Enabled = true;
                button_actualizar.Text = "Modificar Producto";
            }
            else {
                comboBox_Producto.Enabled = false;
                button_actualizar.Text = "Nuevo Producto";
            }
        }

        private void button_mostrar_Click(object sender, EventArgs e)
        {
            LlenarGrilla();
        }
    }
}
