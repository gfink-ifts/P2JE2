namespace Equipo2
{
    partial class Ventas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_datosCliente = new System.Windows.Forms.GroupBox();
            this.dataGridView_ventas = new System.Windows.Forms.DataGridView();
            this.button_nuevaVenta = new System.Windows.Forms.Button();
            this.button_cerrar = new System.Windows.Forms.Button();
            this.textBox_dni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_buscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_apellidoCliente = new System.Windows.Forms.Label();
            this.label_dniCliente = new System.Windows.Forms.Label();
            this.label_nroCli = new System.Windows.Forms.Label();
            this.groupBox_datosProducto = new System.Windows.Forms.GroupBox();
            this.comboBox_productos = new System.Windows.Forms.ComboBox();
            this.textBox_cantprod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_stock = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox_datosCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ventas)).BeginInit();
            this.groupBox_datosProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_datosCliente
            // 
            this.groupBox_datosCliente.Controls.Add(this.label_nroCli);
            this.groupBox_datosCliente.Controls.Add(this.label_dniCliente);
            this.groupBox_datosCliente.Controls.Add(this.label_apellidoCliente);
            this.groupBox_datosCliente.Controls.Add(this.label4);
            this.groupBox_datosCliente.Controls.Add(this.label3);
            this.groupBox_datosCliente.Controls.Add(this.label2);
            this.groupBox_datosCliente.Controls.Add(this.button_buscar);
            this.groupBox_datosCliente.Controls.Add(this.label1);
            this.groupBox_datosCliente.Controls.Add(this.textBox_dni);
            this.groupBox_datosCliente.Location = new System.Drawing.Point(13, 13);
            this.groupBox_datosCliente.Name = "groupBox_datosCliente";
            this.groupBox_datosCliente.Size = new System.Drawing.Size(246, 173);
            this.groupBox_datosCliente.TabIndex = 0;
            this.groupBox_datosCliente.TabStop = false;
            this.groupBox_datosCliente.Text = "Datos del Cliente";
            // 
            // dataGridView_ventas
            // 
            this.dataGridView_ventas.AllowUserToAddRows = false;
            this.dataGridView_ventas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ventas.Location = new System.Drawing.Point(13, 192);
            this.dataGridView_ventas.Name = "dataGridView_ventas";
            this.dataGridView_ventas.RowHeadersVisible = false;
            this.dataGridView_ventas.Size = new System.Drawing.Size(621, 246);
            this.dataGridView_ventas.TabIndex = 1;
            // 
            // button_nuevaVenta
            // 
            this.button_nuevaVenta.Location = new System.Drawing.Point(537, 68);
            this.button_nuevaVenta.Name = "button_nuevaVenta";
            this.button_nuevaVenta.Size = new System.Drawing.Size(75, 50);
            this.button_nuevaVenta.TabIndex = 2;
            this.button_nuevaVenta.Text = "Nueva Venta";
            this.button_nuevaVenta.UseVisualStyleBackColor = true;
            this.button_nuevaVenta.Click += new System.EventHandler(this.button_nuevaVenta_Click);
            // 
            // button_cerrar
            // 
            this.button_cerrar.Location = new System.Drawing.Point(547, 451);
            this.button_cerrar.Name = "button_cerrar";
            this.button_cerrar.Size = new System.Drawing.Size(84, 23);
            this.button_cerrar.TabIndex = 3;
            this.button_cerrar.Text = "Cerrar";
            this.button_cerrar.UseVisualStyleBackColor = true;
            this.button_cerrar.Click += new System.EventHandler(this.button_cerrar_Click);
            // 
            // textBox_dni
            // 
            this.textBox_dni.Location = new System.Drawing.Point(20, 53);
            this.textBox_dni.Name = "textBox_dni";
            this.textBox_dni.Size = new System.Drawing.Size(100, 20);
            this.textBox_dni.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DNI Cliente:";
            // 
            // button_buscar
            // 
            this.button_buscar.Location = new System.Drawing.Point(138, 51);
            this.button_buscar.Name = "button_buscar";
            this.button_buscar.Size = new System.Drawing.Size(75, 23);
            this.button_buscar.TabIndex = 2;
            this.button_buscar.Text = "Buscar";
            this.button_buscar.UseVisualStyleBackColor = true;
            this.button_buscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "DNI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Numero Cliente:";
            // 
            // label_apellidoCliente
            // 
            this.label_apellidoCliente.AutoSize = true;
            this.label_apellidoCliente.Location = new System.Drawing.Point(120, 92);
            this.label_apellidoCliente.Name = "label_apellidoCliente";
            this.label_apellidoCliente.Size = new System.Drawing.Size(10, 13);
            this.label_apellidoCliente.TabIndex = 6;
            this.label_apellidoCliente.Text = "-";
            // 
            // label_dniCliente
            // 
            this.label_dniCliente.AutoSize = true;
            this.label_dniCliente.Location = new System.Drawing.Point(121, 120);
            this.label_dniCliente.Name = "label_dniCliente";
            this.label_dniCliente.Size = new System.Drawing.Size(10, 13);
            this.label_dniCliente.TabIndex = 7;
            this.label_dniCliente.Text = "-";
            // 
            // label_nroCli
            // 
            this.label_nroCli.AutoSize = true;
            this.label_nroCli.Location = new System.Drawing.Point(121, 147);
            this.label_nroCli.Name = "label_nroCli";
            this.label_nroCli.Size = new System.Drawing.Size(10, 13);
            this.label_nroCli.TabIndex = 8;
            this.label_nroCli.Text = "-";
            // 
            // groupBox_datosProducto
            // 
            this.groupBox_datosProducto.Controls.Add(this.label8);
            this.groupBox_datosProducto.Controls.Add(this.label_stock);
            this.groupBox_datosProducto.Controls.Add(this.label6);
            this.groupBox_datosProducto.Controls.Add(this.label5);
            this.groupBox_datosProducto.Controls.Add(this.textBox_cantprod);
            this.groupBox_datosProducto.Controls.Add(this.comboBox_productos);
            this.groupBox_datosProducto.Location = new System.Drawing.Point(284, 13);
            this.groupBox_datosProducto.Name = "groupBox_datosProducto";
            this.groupBox_datosProducto.Size = new System.Drawing.Size(234, 173);
            this.groupBox_datosProducto.TabIndex = 4;
            this.groupBox_datosProducto.TabStop = false;
            this.groupBox_datosProducto.Text = "Datos del Producto";
            // 
            // comboBox_productos
            // 
            this.comboBox_productos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_productos.FormattingEnabled = true;
            this.comboBox_productos.Location = new System.Drawing.Point(107, 37);
            this.comboBox_productos.Name = "comboBox_productos";
            this.comboBox_productos.Size = new System.Drawing.Size(121, 21);
            this.comboBox_productos.TabIndex = 0;
            this.comboBox_productos.SelectionChangeCommitted += new System.EventHandler(this.comboBox_productos_SelectionChangeCommitted);
            // 
            // textBox_cantprod
            // 
            this.textBox_cantprod.Location = new System.Drawing.Point(134, 144);
            this.textBox_cantprod.Name = "textBox_cantprod";
            this.textBox_cantprod.Size = new System.Drawing.Size(94, 20);
            this.textBox_cantprod.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Producto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Cantidad a comprar:";
            // 
            // label_stock
            // 
            this.label_stock.AutoSize = true;
            this.label_stock.Location = new System.Drawing.Point(104, 92);
            this.label_stock.Name = "label_stock";
            this.label_stock.Size = new System.Drawing.Size(10, 13);
            this.label_stock.TabIndex = 4;
            this.label_stock.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Stock:";
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 486);
            this.Controls.Add(this.groupBox_datosProducto);
            this.Controls.Add(this.button_cerrar);
            this.Controls.Add(this.button_nuevaVenta);
            this.Controls.Add(this.dataGridView_ventas);
            this.Controls.Add(this.groupBox_datosCliente);
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.groupBox_datosCliente.ResumeLayout(false);
            this.groupBox_datosCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ventas)).EndInit();
            this.groupBox_datosProducto.ResumeLayout(false);
            this.groupBox_datosProducto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_datosCliente;
        private System.Windows.Forms.DataGridView dataGridView_ventas;
        private System.Windows.Forms.Button button_nuevaVenta;
        private System.Windows.Forms.Button button_cerrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_dni;
        private System.Windows.Forms.Label label_nroCli;
        private System.Windows.Forms.Label label_dniCliente;
        private System.Windows.Forms.Label label_apellidoCliente;
        private System.Windows.Forms.GroupBox groupBox_datosProducto;
        private System.Windows.Forms.ComboBox comboBox_productos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_stock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_cantprod;
    }
}