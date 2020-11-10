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
    public partial class Cliente_Modificar : Form
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

        public Cliente_Modificar()
        {
            InitializeComponent();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            int id;
            if (!string.IsNullOrEmpty(txt_nroCli.Text) && (int.TryParse(txt_nroCli.Text, out id))){
                id = int.Parse(txt_nroCli.Text);
                BuscarCliente(id);
            }
            else {
                MessageBox.Show("Error en los datos a buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscarCliente(int id) {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            Abrir();
            da = new SqlDataAdapter("Select idcliente, nombre, apellido, direccion, dni from Clientes where idcliente=@id", conexion);
            da.SelectCommand.Parameters.AddWithValue("@id", id);
            da.Fill(dt);
            Cerrar(); 

            if (dt.Rows.Count > 0)
            {
                dataGridView_dataCliente.DataSource = dt;
                label_nroCliente.Text = dt.Rows[0][0].ToString();
                txt_nomCli.Text = dt.Rows[0][1].ToString();
                txt_apeCli.Text = dt.Rows[0][2].ToString();
                txt_direCli.Text = dt.Rows[0][3].ToString();
                txt_dniCli.Text = dt.Rows[0][4].ToString();
            }
            else {
                MessageBox.Show("No hay datos del cliente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarTxtBox();
            }
            
        }

        private void LimpiarTxtBox() {
            label_nroCliente.Text = "-";
            txt_nomCli.Text = "";
            txt_apeCli.Text = "";
            txt_direCli.Text = "";
            txt_dniCli.Text = "";
            dataGridView_dataCliente.DataSource = null;
        }

        private void btn_salir4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_editarCli_Click(object sender, EventArgs e)
        {
            if (label_nroCliente.Text != "-")
            {
                if (VerificarContenidoTxt())
                {
                    string nombre = txt_nomCli.Text;
                    string apellido = txt_apeCli.Text;
                    string dni = txt_dniCli.Text;
                    string direccion = txt_direCli.Text;
                    int id = int.Parse(label_nroCliente.Text);
                    if (ActualizarCliente(nombre, apellido, dni, direccion, id))
                    {
                        MessageBox.Show("Actualización exitosa.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarTxtBox();
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else {
                    MessageBox.Show("Error en los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else {
                MessageBox.Show("No hay cliente seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool VerificarContenidoTxt() {
            if (!string.IsNullOrEmpty(txt_apeCli.Text) && !string.IsNullOrEmpty(txt_direCli.Text) && !string.IsNullOrEmpty(txt_dniCli.Text)
                && !string.IsNullOrEmpty(txt_nomCli.Text))
            {
                return true;
            }
            else {
                return false;
            }
        }

        private bool ActualizarCliente(string nombre, string apellido, string dni, string direccion, int id) {
            SqlCommand comando;

            string actualizacion = "update clientes set nombre=@nombre, apellido=@ape, direccion=@dir, dni=@dni" +
                   " where idcliente = @id";
            Abrir();
            comando = new SqlCommand(actualizacion, conexion);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@ape", apellido);
            comando.Parameters.AddWithValue("@dir", direccion);
            comando.Parameters.AddWithValue("@dni", dni);
            comando.Parameters.AddWithValue("@id", id);

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
}
