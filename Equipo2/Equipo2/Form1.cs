using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Equipo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_reportes_Click(object sender, EventArgs e)
        {
            Reportes form = new Reportes();
            form.Show();
        }

        private void button_cerrar_Click(object sender, EventArgs e)
        {
            Close();
            GC.Collect();
        }

        private void button_cliente_Click(object sender, EventArgs e)
        {
            Clientes form = new Clientes();
            form.Show();
        }

        private void button_productos_Click(object sender, EventArgs e)
        {
            Productos form = new Productos();
            form.Show();
        }

        private void button_ventas_Click(object sender, EventArgs e)
        {
            Ventas form = new Ventas();
            form.Show();
        }
    }
}
