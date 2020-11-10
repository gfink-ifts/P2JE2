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
    public partial class Clientes : Form
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

        public Clientes()
        {
            InitializeComponent();
            LlenarGrilla();
        }

        private void LlenarGrilla() {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string consulta = "select idCliente as Num_Cli, nombre, apellido, direccion, dni " +
                "from clientes";
            Abrir();
            da = new SqlDataAdapter(consulta, conexion);
            da.Fill(dt);
            Cerrar();
            dataGridView_clientes.DataSource = dt;
        }

        private void btn_altaCliente_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_apeCliente.Text) && !string.IsNullOrEmpty(txt_direccCliente.Text)
                && !string.IsNullOrEmpty(txt_dniCliente.Text) && !string.IsNullOrEmpty(txt_nombreCliente.Text))
            {
                string nombre = txt_nombreCliente.Text;
                string apellido = txt_apeCliente.Text;
                string direcc = txt_direccCliente.Text;
                string documento = txt_dniCliente.Text;
                if (InsertarCliente(nombre, apellido, direcc, documento))
                {
                    MessageBox.Show("Alta exitosa.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarTxtBox();
                    LlenarGrilla();
                }
                else {
                    MessageBox.Show("Error al guardar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else {
                MessageBox.Show("Error en los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void LimpiarTxtBox() {
            txt_apeCliente.Text = "";
            txt_direccCliente.Text = "";
            txt_dniCliente.Text = "";
            txt_nombreCliente.Text = "";
        }

        private bool InsertarCliente(string nombre, string apellido, string direccion, string documento) {
            SqlCommand comando;

            string consulta = "INSERT INTO Clientes (nombre,apellido,direccion,dni,habilitado)" +
            "VALUES(@nomCli,@apeCli,@direccCli,@dniCli,@habilitado)";

            Abrir();
            comando = new SqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@nomCli", nombre);
            comando.Parameters.AddWithValue("@apeCli", apellido);
            comando.Parameters.AddWithValue("@direccCli", direccion);
            comando.Parameters.AddWithValue("@dniCli", documento);
            comando.Parameters.AddWithValue("@habilitado", "1");

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

        private void btn_modifCli_Click(object sender, EventArgs e)
        {
            Cliente_Modificar form = new Cliente_Modificar();
            form.Show();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_borrarCli2_Click(object sender, EventArgs e)
        {
            Cliente_Eliminar form = new Cliente_Eliminar();
            form.Show();
        }
    }
}
