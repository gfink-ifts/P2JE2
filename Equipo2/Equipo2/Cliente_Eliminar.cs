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
    public partial class Cliente_Eliminar : Form
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

        public Cliente_Eliminar()
        {
            InitializeComponent();
        }

        int idClienteData = -1;
        string dniClienteData = "";

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            int id;
            if (!string.IsNullOrEmpty(txt_nroCli.Text) && (int.TryParse(txt_nroCli.Text, out id)))
            {
                id = int.Parse(txt_nroCli.Text);
                BuscarCliente(id);
            }
            else
            {
                MessageBox.Show("Error en los datos a buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscarCliente(int id)
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            Abrir();
            da = new SqlDataAdapter("Select idcliente as Nro_Cliente, nombre, apellido, direccion, dni, habilitado from Clientes where idcliente=@id", conexion);
            da.SelectCommand.Parameters.AddWithValue("@id", id);
            da.Fill(dt);
            Cerrar();

            if (dt.Rows.Count > 0)
            {
                dataGridView_cliente.DataSource = dt;
                idClienteData = int.Parse(dt.Rows[0][0].ToString());
                dniClienteData = dt.Rows[0][4].ToString();
            }
            else
            {
                MessageBox.Show("No hay datos del cliente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarTxtBox();
            }

        }

        private void LimpiarTxtBox() {
            txt_nroCli.Text = "";
            dataGridView_cliente.DataSource = null;
            idClienteData = -1;
            dniClienteData = "";
        }

        private void btn_salir3_Click(object sender, EventArgs e)
        {
            this.Close();
            GC.Collect();
        }

        private void btn_borrarCli_Click(object sender, EventArgs e)
        {
            if (idClienteData != -1)
            {
                DialogResult dialogResult = MessageBox.Show("¿Desea eliminar el cliente con DNI: " + dniClienteData + "?","Borrar Cliente.", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
                if (dialogResult == DialogResult.Yes) {
                    if (EliminarCliente(idClienteData))
                    {
                        MessageBox.Show("Borrado con exito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarTxtBox();
                    }
                    else {
                        MessageBox.Show("Error en el Borrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else {
                MessageBox.Show("No se selecciono Cliente a eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool EliminarCliente(int id) {
            SqlCommand comando;
            string actualizacion = "update clientes set habilitado=@habilitado where idcliente=@id";
            Abrir();
            comando = new SqlCommand(actualizacion, conexion);
            comando.Parameters.AddWithValue("@habilitado", "0");
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
