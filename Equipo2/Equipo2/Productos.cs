﻿using System;
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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void button_tipoProducto_Click(object sender, EventArgs e)
        {
            Tipo_Producto form = new Tipo_Producto();
            form.Show();
        }
    }
}