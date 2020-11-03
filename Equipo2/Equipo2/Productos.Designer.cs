namespace Equipo2
{
    partial class Productos
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
            this.button_tipoProducto = new System.Windows.Forms.Button();
            this.button_cerrar = new System.Windows.Forms.Button();
            this.groupBox_modificarProducto = new System.Windows.Forms.GroupBox();
            this.label_cantidad = new System.Windows.Forms.Label();
            this.textBox_cantidad = new System.Windows.Forms.TextBox();
            this.textBox_descripcion = new System.Windows.Forms.TextBox();
            this.label_descripcion = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_precio = new System.Windows.Forms.Label();
            this.comboBox_Producto = new System.Windows.Forms.ComboBox();
            this.textBox_precio = new System.Windows.Forms.TextBox();
            this.label_tipoProducto = new System.Windows.Forms.Label();
            this.button_actualizar = new System.Windows.Forms.Button();
            this.comboBox_tipo = new System.Windows.Forms.ComboBox();
            this.checkBox_modificarProducto = new System.Windows.Forms.CheckBox();
            this.dataGridView_productos = new System.Windows.Forms.DataGridView();
            this.button_mostrar = new System.Windows.Forms.Button();
            this.groupBox_modificarProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_productos)).BeginInit();
            this.SuspendLayout();
            // 
            // button_tipoProducto
            // 
            this.button_tipoProducto.Location = new System.Drawing.Point(12, 386);
            this.button_tipoProducto.Name = "button_tipoProducto";
            this.button_tipoProducto.Size = new System.Drawing.Size(75, 52);
            this.button_tipoProducto.TabIndex = 0;
            this.button_tipoProducto.Text = "Agregar Tipo Producto";
            this.button_tipoProducto.UseVisualStyleBackColor = true;
            this.button_tipoProducto.Click += new System.EventHandler(this.button_tipoProducto_Click);
            // 
            // button_cerrar
            // 
            this.button_cerrar.Location = new System.Drawing.Point(713, 386);
            this.button_cerrar.Name = "button_cerrar";
            this.button_cerrar.Size = new System.Drawing.Size(75, 52);
            this.button_cerrar.TabIndex = 1;
            this.button_cerrar.Text = "Cerrar";
            this.button_cerrar.UseVisualStyleBackColor = true;
            this.button_cerrar.Click += new System.EventHandler(this.button_cerrar_Click);
            // 
            // groupBox_modificarProducto
            // 
            this.groupBox_modificarProducto.Controls.Add(this.label_cantidad);
            this.groupBox_modificarProducto.Controls.Add(this.textBox_cantidad);
            this.groupBox_modificarProducto.Controls.Add(this.textBox_descripcion);
            this.groupBox_modificarProducto.Controls.Add(this.label_descripcion);
            this.groupBox_modificarProducto.Controls.Add(this.label4);
            this.groupBox_modificarProducto.Controls.Add(this.label_precio);
            this.groupBox_modificarProducto.Controls.Add(this.comboBox_Producto);
            this.groupBox_modificarProducto.Controls.Add(this.textBox_precio);
            this.groupBox_modificarProducto.Controls.Add(this.label_tipoProducto);
            this.groupBox_modificarProducto.Controls.Add(this.button_actualizar);
            this.groupBox_modificarProducto.Controls.Add(this.comboBox_tipo);
            this.groupBox_modificarProducto.Controls.Add(this.checkBox_modificarProducto);
            this.groupBox_modificarProducto.Location = new System.Drawing.Point(13, 59);
            this.groupBox_modificarProducto.Name = "groupBox_modificarProducto";
            this.groupBox_modificarProducto.Size = new System.Drawing.Size(253, 321);
            this.groupBox_modificarProducto.TabIndex = 2;
            this.groupBox_modificarProducto.TabStop = false;
            this.groupBox_modificarProducto.Text = "Productos";
            // 
            // label_cantidad
            // 
            this.label_cantidad.AutoSize = true;
            this.label_cantidad.Location = new System.Drawing.Point(26, 200);
            this.label_cantidad.Name = "label_cantidad";
            this.label_cantidad.Size = new System.Drawing.Size(52, 13);
            this.label_cantidad.TabIndex = 19;
            this.label_cantidad.Text = "Cantidad:";
            // 
            // textBox_cantidad
            // 
            this.textBox_cantidad.Location = new System.Drawing.Point(110, 193);
            this.textBox_cantidad.Name = "textBox_cantidad";
            this.textBox_cantidad.Size = new System.Drawing.Size(100, 20);
            this.textBox_cantidad.TabIndex = 20;
            // 
            // textBox_descripcion
            // 
            this.textBox_descripcion.Location = new System.Drawing.Point(110, 109);
            this.textBox_descripcion.Name = "textBox_descripcion";
            this.textBox_descripcion.Size = new System.Drawing.Size(100, 20);
            this.textBox_descripcion.TabIndex = 11;
            // 
            // label_descripcion
            // 
            this.label_descripcion.AutoSize = true;
            this.label_descripcion.Location = new System.Drawing.Point(26, 109);
            this.label_descripcion.Name = "label_descripcion";
            this.label_descripcion.Size = new System.Drawing.Size(66, 13);
            this.label_descripcion.TabIndex = 10;
            this.label_descripcion.Text = "Descripcion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Producto:";
            // 
            // label_precio
            // 
            this.label_precio.AutoSize = true;
            this.label_precio.Location = new System.Drawing.Point(26, 157);
            this.label_precio.Name = "label_precio";
            this.label_precio.Size = new System.Drawing.Size(40, 13);
            this.label_precio.TabIndex = 12;
            this.label_precio.Text = "Precio:";
            // 
            // comboBox_Producto
            // 
            this.comboBox_Producto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Producto.FormattingEnabled = true;
            this.comboBox_Producto.Location = new System.Drawing.Point(110, 73);
            this.comboBox_Producto.Name = "comboBox_Producto";
            this.comboBox_Producto.Size = new System.Drawing.Size(100, 21);
            this.comboBox_Producto.TabIndex = 17;
            this.comboBox_Producto.SelectedValueChanged += new System.EventHandler(this.comboBox_Producto_SelectedValueChanged);
            // 
            // textBox_precio
            // 
            this.textBox_precio.Location = new System.Drawing.Point(110, 150);
            this.textBox_precio.Name = "textBox_precio";
            this.textBox_precio.Size = new System.Drawing.Size(100, 20);
            this.textBox_precio.TabIndex = 13;
            // 
            // label_tipoProducto
            // 
            this.label_tipoProducto.AutoSize = true;
            this.label_tipoProducto.Location = new System.Drawing.Point(26, 242);
            this.label_tipoProducto.Name = "label_tipoProducto";
            this.label_tipoProducto.Size = new System.Drawing.Size(31, 13);
            this.label_tipoProducto.TabIndex = 16;
            this.label_tipoProducto.Text = "Tipo:";
            // 
            // button_actualizar
            // 
            this.button_actualizar.Location = new System.Drawing.Point(29, 276);
            this.button_actualizar.Name = "button_actualizar";
            this.button_actualizar.Size = new System.Drawing.Size(181, 23);
            this.button_actualizar.TabIndex = 14;
            this.button_actualizar.Text = "Nuevo Producto";
            this.button_actualizar.UseVisualStyleBackColor = true;
            this.button_actualizar.Click += new System.EventHandler(this.button_actualizar_Click);
            // 
            // comboBox_tipo
            // 
            this.comboBox_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tipo.FormattingEnabled = true;
            this.comboBox_tipo.Location = new System.Drawing.Point(110, 234);
            this.comboBox_tipo.Name = "comboBox_tipo";
            this.comboBox_tipo.Size = new System.Drawing.Size(100, 21);
            this.comboBox_tipo.TabIndex = 15;
            // 
            // checkBox_modificarProducto
            // 
            this.checkBox_modificarProducto.AutoSize = true;
            this.checkBox_modificarProducto.Location = new System.Drawing.Point(20, 30);
            this.checkBox_modificarProducto.Name = "checkBox_modificarProducto";
            this.checkBox_modificarProducto.Size = new System.Drawing.Size(115, 17);
            this.checkBox_modificarProducto.TabIndex = 0;
            this.checkBox_modificarProducto.Text = "Modificar Producto";
            this.checkBox_modificarProducto.UseVisualStyleBackColor = true;
            this.checkBox_modificarProducto.CheckedChanged += new System.EventHandler(this.checkBox_modificarProducto_CheckedChanged);
            // 
            // dataGridView_productos
            // 
            this.dataGridView_productos.AllowUserToAddRows = false;
            this.dataGridView_productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_productos.Location = new System.Drawing.Point(280, 13);
            this.dataGridView_productos.Name = "dataGridView_productos";
            this.dataGridView_productos.RowHeadersVisible = false;
            this.dataGridView_productos.Size = new System.Drawing.Size(508, 367);
            this.dataGridView_productos.TabIndex = 3;
            // 
            // button_mostrar
            // 
            this.button_mostrar.Location = new System.Drawing.Point(53, 21);
            this.button_mostrar.Name = "button_mostrar";
            this.button_mostrar.Size = new System.Drawing.Size(187, 23);
            this.button_mostrar.TabIndex = 4;
            this.button_mostrar.Text = "Mostrar Productos";
            this.button_mostrar.UseVisualStyleBackColor = true;
            this.button_mostrar.Click += new System.EventHandler(this.button_mostrar_Click);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_mostrar);
            this.Controls.Add(this.dataGridView_productos);
            this.Controls.Add(this.groupBox_modificarProducto);
            this.Controls.Add(this.button_cerrar);
            this.Controls.Add(this.button_tipoProducto);
            this.Name = "Productos";
            this.Text = "Productos";
            this.groupBox_modificarProducto.ResumeLayout(false);
            this.groupBox_modificarProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_productos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_tipoProducto;
        private System.Windows.Forms.Button button_cerrar;
        private System.Windows.Forms.GroupBox groupBox_modificarProducto;
        private System.Windows.Forms.Label label_cantidad;
        private System.Windows.Forms.TextBox textBox_cantidad;
        private System.Windows.Forms.TextBox textBox_descripcion;
        private System.Windows.Forms.Label label_descripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_precio;
        private System.Windows.Forms.ComboBox comboBox_Producto;
        private System.Windows.Forms.TextBox textBox_precio;
        private System.Windows.Forms.Label label_tipoProducto;
        private System.Windows.Forms.Button button_actualizar;
        private System.Windows.Forms.ComboBox comboBox_tipo;
        private System.Windows.Forms.CheckBox checkBox_modificarProducto;
        private System.Windows.Forms.DataGridView dataGridView_productos;
        private System.Windows.Forms.Button button_mostrar;
    }
}