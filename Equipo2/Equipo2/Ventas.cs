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
        }

        private void button_nuevaVenta_Click(object sender, EventArgs e)
        {

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
    }
}
