namespace Equipo2
{
    partial class Reportes
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
            this.dataGridView_resultados = new System.Windows.Forms.DataGridView();
            this.textBox_cliente = new System.Windows.Forms.TextBox();
            this.label_fechaInicio = new System.Windows.Forms.Label();
            this.dateTimePicker_inicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_fin = new System.Windows.Forms.DateTimePicker();
            this.label_fechaFin = new System.Windows.Forms.Label();
            this.button_buscar = new System.Windows.Forms.Button();
            this.comboBox_productos = new System.Windows.Forms.ComboBox();
            this.checkBox_producto = new System.Windows.Forms.CheckBox();
            this.checkBox_cliente = new System.Windows.Forms.CheckBox();
            this.button_exportar = new System.Windows.Forms.Button();
            this.checkBox_fecha = new System.Windows.Forms.CheckBox();
            this.button_salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_resultados)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_resultados
            // 
            this.dataGridView_resultados.AllowUserToAddRows = false;
            this.dataGridView_resultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_resultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_resultados.Location = new System.Drawing.Point(13, 107);
            this.dataGridView_resultados.Name = "dataGridView_resultados";
            this.dataGridView_resultados.RowHeadersVisible = false;
            this.dataGridView_resultados.Size = new System.Drawing.Size(923, 331);
            this.dataGridView_resultados.TabIndex = 0;
            // 
            // textBox_cliente
            // 
            this.textBox_cliente.Location = new System.Drawing.Point(123, 64);
            this.textBox_cliente.Name = "textBox_cliente";
            this.textBox_cliente.Size = new System.Drawing.Size(97, 20);
            this.textBox_cliente.TabIndex = 2;
            // 
            // label_fechaInicio
            // 
            this.label_fechaInicio.AutoSize = true;
            this.label_fechaInicio.Location = new System.Drawing.Point(362, 28);
            this.label_fechaInicio.Name = "label_fechaInicio";
            this.label_fechaInicio.Size = new System.Drawing.Size(68, 13);
            this.label_fechaInicio.TabIndex = 3;
            this.label_fechaInicio.Text = "Fecha Inicio:";
            // 
            // dateTimePicker_inicio
            // 
            this.dateTimePicker_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_inicio.Location = new System.Drawing.Point(436, 24);
            this.dateTimePicker_inicio.Name = "dateTimePicker_inicio";
            this.dateTimePicker_inicio.Size = new System.Drawing.Size(102, 20);
            this.dateTimePicker_inicio.TabIndex = 4;
            // 
            // dateTimePicker_fin
            // 
            this.dateTimePicker_fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_fin.Location = new System.Drawing.Point(436, 70);
            this.dateTimePicker_fin.Name = "dateTimePicker_fin";
            this.dateTimePicker_fin.Size = new System.Drawing.Size(102, 20);
            this.dateTimePicker_fin.TabIndex = 6;
            // 
            // label_fechaFin
            // 
            this.label_fechaFin.AutoSize = true;
            this.label_fechaFin.Location = new System.Drawing.Point(362, 74);
            this.label_fechaFin.Name = "label_fechaFin";
            this.label_fechaFin.Size = new System.Drawing.Size(57, 13);
            this.label_fechaFin.TabIndex = 5;
            this.label_fechaFin.Text = "Fecha Fin:";
            // 
            // button_buscar
            // 
            this.button_buscar.Location = new System.Drawing.Point(606, 34);
            this.button_buscar.Name = "button_buscar";
            this.button_buscar.Size = new System.Drawing.Size(106, 51);
            this.button_buscar.TabIndex = 7;
            this.button_buscar.Text = "Buscar";
            this.button_buscar.UseVisualStyleBackColor = true;
            this.button_buscar.Click += new System.EventHandler(this.button_buscar_Click);
            // 
            // comboBox_productos
            // 
            this.comboBox_productos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_productos.FormattingEnabled = true;
            this.comboBox_productos.Location = new System.Drawing.Point(123, 31);
            this.comboBox_productos.Name = "comboBox_productos";
            this.comboBox_productos.Size = new System.Drawing.Size(97, 21);
            this.comboBox_productos.TabIndex = 8;
            // 
            // checkBox_producto
            // 
            this.checkBox_producto.AutoSize = true;
            this.checkBox_producto.Location = new System.Drawing.Point(23, 33);
            this.checkBox_producto.Name = "checkBox_producto";
            this.checkBox_producto.Size = new System.Drawing.Size(72, 17);
            this.checkBox_producto.TabIndex = 10;
            this.checkBox_producto.Text = "Producto:";
            this.checkBox_producto.UseVisualStyleBackColor = true;
            this.checkBox_producto.CheckedChanged += new System.EventHandler(this.checkBox_producto_CheckedChanged);
            // 
            // checkBox_cliente
            // 
            this.checkBox_cliente.AutoSize = true;
            this.checkBox_cliente.Location = new System.Drawing.Point(23, 67);
            this.checkBox_cliente.Name = "checkBox_cliente";
            this.checkBox_cliente.Size = new System.Drawing.Size(61, 17);
            this.checkBox_cliente.TabIndex = 11;
            this.checkBox_cliente.Text = "Cliente:";
            this.checkBox_cliente.UseVisualStyleBackColor = true;
            this.checkBox_cliente.CheckedChanged += new System.EventHandler(this.checkBox_cliente_CheckedChanged);
            // 
            // button_exportar
            // 
            this.button_exportar.Location = new System.Drawing.Point(830, 34);
            this.button_exportar.Name = "button_exportar";
            this.button_exportar.Size = new System.Drawing.Size(106, 53);
            this.button_exportar.TabIndex = 12;
            this.button_exportar.Text = "Exportar Listado";
            this.button_exportar.UseVisualStyleBackColor = true;
            this.button_exportar.Click += new System.EventHandler(this.button_exportar_Click);
            // 
            // checkBox_fecha
            // 
            this.checkBox_fecha.AutoSize = true;
            this.checkBox_fecha.Location = new System.Drawing.Point(296, 51);
            this.checkBox_fecha.Name = "checkBox_fecha";
            this.checkBox_fecha.Size = new System.Drawing.Size(64, 17);
            this.checkBox_fecha.TabIndex = 13;
            this.checkBox_fecha.Text = "Fechas:";
            this.checkBox_fecha.UseVisualStyleBackColor = true;
            this.checkBox_fecha.CheckedChanged += new System.EventHandler(this.checkBox_fecha_CheckedChanged);
            // 
            // button_salir
            // 
            this.button_salir.Location = new System.Drawing.Point(830, 450);
            this.button_salir.Name = "button_salir";
            this.button_salir.Size = new System.Drawing.Size(106, 23);
            this.button_salir.TabIndex = 14;
            this.button_salir.Text = "Salir";
            this.button_salir.UseVisualStyleBackColor = true;
            this.button_salir.Click += new System.EventHandler(this.button_salir_Click);
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 485);
            this.Controls.Add(this.button_salir);
            this.Controls.Add(this.checkBox_fecha);
            this.Controls.Add(this.button_exportar);
            this.Controls.Add(this.checkBox_cliente);
            this.Controls.Add(this.checkBox_producto);
            this.Controls.Add(this.comboBox_productos);
            this.Controls.Add(this.button_buscar);
            this.Controls.Add(this.dateTimePicker_fin);
            this.Controls.Add(this.label_fechaFin);
            this.Controls.Add(this.dateTimePicker_inicio);
            this.Controls.Add(this.label_fechaInicio);
            this.Controls.Add(this.textBox_cliente);
            this.Controls.Add(this.dataGridView_resultados);
            this.Name = "Reportes";
            this.Text = "Reportes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_resultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_resultados;
        private System.Windows.Forms.TextBox textBox_cliente;
        private System.Windows.Forms.Label label_fechaInicio;
        private System.Windows.Forms.DateTimePicker dateTimePicker_inicio;
        private System.Windows.Forms.DateTimePicker dateTimePicker_fin;
        private System.Windows.Forms.Label label_fechaFin;
        private System.Windows.Forms.Button button_buscar;
        private System.Windows.Forms.ComboBox comboBox_productos;
        private System.Windows.Forms.CheckBox checkBox_producto;
        private System.Windows.Forms.CheckBox checkBox_cliente;
        private System.Windows.Forms.Button button_exportar;
        private System.Windows.Forms.CheckBox checkBox_fecha;
        private System.Windows.Forms.Button button_salir;
    }
}