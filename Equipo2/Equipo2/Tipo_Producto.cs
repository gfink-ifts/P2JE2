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
    public partial class Tipo_Producto : Form
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


        public Tipo_Producto()
        {
            InitializeComponent();
            LlenarCombo();
            LlenarGrilla();
            InicializarFormulario();
        }

        private void button_salir_Click(object sender, EventArgs e)
        {
            Close();
            GC.Collect();
        }

        private void LlenarCombo() {

                SqlDataAdapter da;
                DataTable dt = new DataTable();

                string consulta = "SELECT idTipo, descripcion FROM tipo_producto";
                Abrir();
                da = new SqlDataAdapter(consulta, conexion);
                da.Fill(dt);
                Cerrar();
            comboBox_listado.DataSource = dt;
            comboBox_listado.ValueMember = "idtipo";
            comboBox_listado.DisplayMember = "descripcion";
        }

        private void LlenarGrilla() {
            SqlDataAdapter da;
            DataTable dt = new DataTable();

            string consulta = "SELECT idTipo, descripcion FROM tipo_producto";
            Abrir();
            da = new SqlDataAdapter(consulta, conexion);
            da.Fill(dt);
            Cerrar();
            dataGridView1.DataSource = dt;

        }

        private void InicializarFormulario() {
            comboBox_listado.Enabled = false;
            textBox_descripcion.Text = "";
        
        }

        private void button_agregar_Click(object sender, EventArgs e)
        {
            string descripcion = null;
            int id = -1;

            if (!string.IsNullOrWhiteSpace(textBox_descripcion.Text))
            {
                if (checkBox_Modificar.Checked)
                {
                    id = int.Parse(comboBox_listado.SelectedValue.ToString());
                    descripcion = textBox_descripcion.Text;
                    ActualizarRegistro(descripcion,id);
                    LlenarCombo();
                    LlenarGrilla();
                }
                else
                {
                    descripcion = textBox_descripcion.Text;
                    ActualizarRegistro(descripcion, id);
                    LlenarCombo();
                    LlenarGrilla();
                }
            }
            else {
                MessageBox.Show("El campo descripcion no debe ser vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void ActualizarRegistro(string descripcion, int producto) {
            SqlCommand comando;

            if (producto == -1)
            {
                string insertar = "insert into tipo_producto (descripcion) values (@descripcion)";
                Abrir();
                comando = new SqlCommand(insertar, conexion);
                comando.Parameters.AddWithValue("@descripcion", descripcion);

                comando.ExecuteNonQuery();
                Cerrar();

            }
            else {
                string actualizacion = "update tipo_producto set descripcion=@descripcion where idTipo = @producto";
                Abrir();
                comando = new SqlCommand(actualizacion, conexion);
                comando.Parameters.AddWithValue("@descripcion", descripcion);
                comando.Parameters.AddWithValue("@producto", producto);

                comando.ExecuteNonQuery();
                Cerrar();
            }


        }

        private void checkBox_Modificar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Modificar.Checked)
            {
                comboBox_listado.Enabled = true;
                button_agregar.Text = "Actualizar";
            }
            else {
                comboBox_listado.Enabled = false;
                button_agregar.Text = "Agregar";
            }
        }

        private void comboBox_listado_SelectedValueChanged(object sender, EventArgs e)
        {
            if (checkBox_Modificar.Checked)
            {
                int id = int.Parse(comboBox_listado.SelectedValue.ToString());
                SqlDataAdapter da;
                DataTable dt = new DataTable();
                Abrir();
                string consulta = "select tp.descripcion as Descripcion from tipo_producto as tp " +
                    "where tp.idtipo = @idtipo";

                da = new SqlDataAdapter(consulta, conexion);
                da.SelectCommand.Parameters.AddWithValue("@idtipo", id);
                da.Fill(dt);
                Cerrar();

                if (dt.Rows.Count > 0)
                {
                    textBox_descripcion.Text = dt.Rows[0][0].ToString();
                }
                else
                {
                    MessageBox.Show("No se encontró información");
                }
            }
        }
    }
}
