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
    public partial class Ventas : Form
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
        public Ventas()
        {
            InitializeComponent();
            LlenarGrilla();
            LlenarComboProductos();

        }

        private void button_nuevaVenta_Click(object sender, EventArgs e)
        {
            int cantidad;
            int stock;
            if (VerificarStock() && VerificarCliente())
            {
                cantidad = int.Parse(textBox_cantprod.Text);
                int idCli = int.Parse(label_nroCli.Text);
                int idprod = int.Parse(comboBox_productos.SelectedValue.ToString());
                stock = int.Parse(label_stock.Text);
                if (InsertarVenta(cantidad, idCli, idprod,stock))
                {
                    MessageBox.Show("Alta Exitosa.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    LlenarGrilla();
                    LlenarComboProductos();
                }
                else {
                    MessageBox.Show("Error al registrar la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private bool InsertarVenta(int cantidad, int idCliente,int idProd, int stock) {
            SqlCommand comando;

                string insertar = "insert into ventas (fechaventa,idcliente,idproducto,cantidad) " +
                    "values (@fecha,@idcliente,@idprod,@cantidad)";
                Abrir();

                comando = new SqlCommand(insertar, conexion);
                comando.Parameters.AddWithValue("@fecha", DateTime.Now.ToShortDateString());
                comando.Parameters.AddWithValue("@idcliente", idCliente);
                comando.Parameters.AddWithValue("@idprod", idProd);
                comando.Parameters.AddWithValue("@cantidad", cantidad);

                int resultado = comando.ExecuteNonQuery();
                Cerrar();
                if (resultado == 1 && ActualizarStock(idProd,cantidad,stock))
                {
                    return true;
                }
                else
                {
                    return false;
                }

         }

        private bool ActualizarStock(int idprod, int cantidad,int stock) {
            SqlCommand comando;

            string update = "update productos set cantidad=@cantidad where idproducto=@idprod";
            Abrir();

            comando = new SqlCommand(update, conexion);
            comando.Parameters.AddWithValue("@idprod", idprod);
            comando.Parameters.AddWithValue("@cantidad", stock - cantidad);

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

        private void Limpiar() {
            textBox_dni.Text = "";
            label_dniCliente.Text = "-";
            label_apellidoCliente.Text = "-";
            label_nroCli.Text = "-";
            textBox_cantprod.Text = "";
            label_stock.Text = "-";
        }

        private bool VerificarCliente() {
            int num;
            if (int.TryParse(label_nroCli.Text, out num))
            {
                return true;
            }
            else {
                MessageBox.Show("No se seleccionó el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        
        }

        private bool VerificarStock() {
            int cantidad;
            int stock;

            if (int.TryParse(textBox_cantprod.Text, out cantidad) && int.Parse(textBox_cantprod.Text) > 0)
            {
                if (int.TryParse(label_stock.Text, out stock)) {
                    if (int.Parse(label_stock.Text) >= int.Parse(textBox_cantprod.Text)) {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("La cantidad a comprar es mayor al stock disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                MessageBox.Show("No se seleccionó el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else {
                MessageBox.Show("La cantidad debe ser un numero o debe ser mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void LlenarGrilla() {

            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string consulta = "select v.fechaVenta,c.nombre, c.apellido, p.descripcion , p.precio, v.cantidad, (v.cantidad * p.precio) as Total " +
                                "from ventas as v, Clientes as c, Productos as p " +
                                "where v.idcliente = c.idCliente and v.idproducto = p.idProducto";
            Abrir();
            da = new SqlDataAdapter(consulta, conexion);
            da.Fill(dt);
            Cerrar();
            dataGridView_ventas.DataSource = dt;

        }

        private void button_cerrar_Click(object sender, EventArgs e)
        {
            Close();
            GC.Collect();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox_dni.Text))
            {
                BuscarCliente(textBox_dni.Text);
            }
            else {
                MessageBox.Show("Error en el DNI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LlenarComboProductos() {
            SqlDataAdapter da;
            DataTable dt = new DataTable();

            string consulta = "SELECT idProducto, descripcion FROM productos where cantidad > 0";
            Abrir();
            da = new SqlDataAdapter(consulta, conexion);
            da.Fill(dt);
            Cerrar();
            comboBox_productos.DataSource = dt;
            comboBox_productos.ValueMember = "idProducto";
            comboBox_productos.DisplayMember = "descripcion";
            comboBox_productos.SelectedValue = 0;
        }

        private void BuscarCliente(string dni) {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            //cambio en el diseño de la tabla clientes, se agrega habilitado para baja logica.
            string consulta = "SELECT idcliente, apellido FROM clientes where dni=@dni and habilitado=1";
            Abrir();
            da = new SqlDataAdapter(consulta, conexion);
            da.SelectCommand.Parameters.AddWithValue("@dni", dni);
            da.Fill(dt);
            Cerrar();


            if (dt.Rows.Count > 0)
            {
                label_apellidoCliente.Text = dt.Rows[0][1].ToString();
                label_nroCli.Text = dt.Rows[0][0].ToString();
                label_dniCliente.Text = dni;
            }
            else {
                MessageBox.Show("No existe el cliente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void comboBox_productos_SelectionChangeCommitted(object sender, EventArgs e)
        {

            int producto = int.Parse(comboBox_productos.SelectedValue.ToString());
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            Abrir();
            string consulta = "select cantidad from productos where idproducto = @producto";

            da = new SqlDataAdapter(consulta, conexion);
            da.SelectCommand.Parameters.AddWithValue("@producto", producto);
            da.Fill(dt);
            Cerrar();

            if (dt.Rows.Count > 0)
            {
                label_stock.Text = dt.Rows[0][0].ToString();
            }
            else
            {
                MessageBox.Show("No se encontró información");
            }
        }
    }
}
