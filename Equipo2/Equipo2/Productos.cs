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
            }
            else {
                comboBox_Producto.Enabled = false;
            }
        }
    }
}
