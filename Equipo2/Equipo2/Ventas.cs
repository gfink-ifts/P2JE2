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
            if (int.TryParse(textBox_cantprod.Text, out cantidad) && comboBox_productos.SelectedValue != null && label_stock.Text != "-")
            {

            }
            else {
                MessageBox.Show("La cantidad debe ser un numero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            string consulta = "SELECT idProducto, descripcion FROM productos";
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

            string consulta = "SELECT idcliente, apellido FROM clientes where dni=@dni";
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
