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
using System.IO;

namespace Equipo2
{
    public partial class Reportes : Form
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

        public Reportes()
        {
            InitializeComponent();
            InicializarCheckbox();
            LlenarCombo();
        }

        private void button_buscar_Click(object sender, EventArgs e)
        {
            string fechaFin = null;
            string fechaInicio = null;
            string cliente = null;
            int producto = -1;

            if (checkBox_fecha.Checked)
            {
                if (dateTimePicker_inicio.Value.Date <= dateTimePicker_fin.Value.Date)
                {
                    fechaFin = dateTimePicker_fin.Value.ToShortDateString().ToString();
                    fechaInicio = dateTimePicker_inicio.Value.ToShortDateString().ToString();
                }
                else
                {
                    MessageBox.Show("El día de inicio debe ser menor que el día fin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            if (checkBox_cliente.Checked)
            {
                if (VerificarVacio())
                {
                    cliente = textBox_cliente.Text;
                }
                else
                {
                    MessageBox.Show("El campo Cliente no debe ser vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (checkBox_producto.Checked)
            {
                producto = int.Parse(comboBox_productos.SelectedValue.ToString());
            }

            BuscarVentas(fechaInicio, fechaFin, cliente, producto);

        }


        private void BuscarVentas(string fechaInicio, string fechaFin, string cliente, int producto)
        {

            string consulta = "select v.fechaVenta, c.nombre, c.apellido, p.descripcion, tp.descripcion as Tipo, v.cantidad, p.precio as Precio_Unitario, (p.precio * v.cantidad) as total " +
                "from ventas as v, productos as p, clientes as c, Tipo_Producto as tp where v.idcliente = c.idCliente and v.idproducto = p.idProducto and p.idTipo = tp.idTipo";
            string condiciones = "";

            if (fechaFin != null && fechaInicio != null)
            {
                condiciones += condiciones + " and v.fechaventa between @fechaInicio and @fechaFin";
            }

            if (producto != -1)
            {
                condiciones += condiciones + " and tp.idTipo = @producto";
            }

            if (cliente != null)
            {
                condiciones += condiciones + " and c.apellido like '%"+@cliente+"%'";
            }

            consulta = consulta + condiciones;

            SqlDataAdapter da;
            DataTable dt = new DataTable();
            Abrir();

            da = new SqlDataAdapter(consulta, conexion);

            if (fechaFin != null && fechaInicio != null)
            {
                da.SelectCommand.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                da.SelectCommand.Parameters.AddWithValue("@fechaFin", fechaFin);
            }

            if (producto != -1)
            {
                da.SelectCommand.Parameters.AddWithValue("@producto", producto);
            }

            //if (cliente != null)
            //{
            //    da.SelectCommand.Parameters.AddWithValue("@cliente", cliente);
            //}
            da.Fill(dt);
            Cerrar();

            dataGridView_resultados.DataSource = dt;

        }

        private bool VerificarVacio()
        {
            if (!string.IsNullOrEmpty(textBox_cliente.Text))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void InicializarCheckbox()
        {
            comboBox_productos.Enabled = false;
            textBox_cliente.Enabled = false;
            dateTimePicker_fin.Enabled = false;
            dateTimePicker_inicio.Enabled = false;
        }

        private void LlenarCombo()
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();

            string consulta = "SELECT idTipo, descripcion FROM tipo_producto";
            Abrir();
            da = new SqlDataAdapter(consulta, conexion);
            da.Fill(dt);
            Cerrar();
            comboBox_productos.DataSource = dt;
            comboBox_productos.ValueMember = "idtipo";
            comboBox_productos.DisplayMember = "descripcion";
        }

        private void checkBox_producto_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_producto.Checked)
            {
                comboBox_productos.Enabled = true;
            }
            else
            {
                comboBox_productos.Enabled = false;
            }
        }

        private void checkBox_cliente_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_cliente.Checked)
            {
                textBox_cliente.Enabled = true;
            }
            else
            {
                textBox_cliente.Enabled = false;
            }
        }

        private void checkBox_fecha_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_fecha.Checked)
            {
                dateTimePicker_fin.Enabled = true;
                dateTimePicker_inicio.Enabled = true;
            }
            else
            {
                dateTimePicker_fin.Enabled = false;
                dateTimePicker_inicio.Enabled = false;
            }
        }

        private void button_salir_Click(object sender, EventArgs e)
        {
            Close();
            GC.Collect();
        }

        private void button_exportar_Click(object sender, EventArgs e)
        {
            DataTable ds = new DataTable();
            ds = dataGridView_resultados.DataSource as DataTable;
            if (ds != null)
            {

                using (SaveFileDialog save = new SaveFileDialog())
                {
                    save.Filter = "CSV files (.csv)|.csv|All files (.)|.";
                    save.Title = "Guardar en...";
                    if (save.ShowDialog() == DialogResult.OK)
                    {

                        string strData = ConvertToCSV(ds);
                        string strFileName = save.FileName;
                        File.WriteAllText(strFileName, strData);
                        MessageBox.Show("Archivo generado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else {
                MessageBox.Show("No hay datos en la grilla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ConvertToCSV(DataTable objDataSet)
        {
            StringBuilder content = new StringBuilder();

            if (objDataSet.Rows.Count > 0)
            {
                DataRow dr = (DataRow)objDataSet.Rows[0];
                int intColumnCount = dr.Table.Columns.Count;
                int index = 1;

                //add column names
                foreach (DataColumn item in dr.Table.Columns)
                {
                    content.Append(String.Format("{0}", item.ColumnName));
                    if (index < intColumnCount)
                        content.Append(",");
                    else
                        content.Append("\r\n");
                    index++;
                }
                //add column data
                foreach (DataRow currentRow in objDataSet.Rows)
                {
                    string strRow = string.Empty;
                    for (int y = 0; y <= intColumnCount - 1; y++)
                    {
                        strRow += currentRow[y].ToString();
                        if (y < intColumnCount - 1 && y >= 0)
                            strRow += ",";
                    }
                    content.Append(strRow + "\r\n");
                }
            }
            return content.ToString();
        }

    }
}