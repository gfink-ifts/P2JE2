namespace Equipo2
{
    partial class Tipo_Producto
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
            this.checkBox_Modificar = new System.Windows.Forms.CheckBox();
            this.comboBox_listado = new System.Windows.Forms.ComboBox();
            this.textBox_descripcion = new System.Windows.Forms.TextBox();
            this.label_tipoProdDesc = new System.Windows.Forms.Label();
            this.button_agregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox_Modificar
            // 
            this.checkBox_Modificar.AutoSize = true;
            this.checkBox_Modificar.Location = new System.Drawing.Point(19, 16);
            this.checkBox_Modificar.Name = "checkBox_Modificar";
            this.checkBox_Modificar.Size = new System.Drawing.Size(72, 17);
            this.checkBox_Modificar.TabIndex = 0;
            this.checkBox_Modificar.Text = "Modificar:";
            this.checkBox_Modificar.UseVisualStyleBackColor = true;
            this.checkBox_Modificar.CheckedChanged += new System.EventHandler(this.checkBox_Modificar_CheckedChanged);
            // 
            // comboBox_listado
            // 
            this.comboBox_listado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_listado.FormattingEnabled = true;
            this.comboBox_listado.Location = new System.Drawing.Point(109, 12);
            this.comboBox_listado.Name = "comboBox_listado";
            this.comboBox_listado.Size = new System.Drawing.Size(120, 21);
            this.comboBox_listado.TabIndex = 1;
            this.comboBox_listado.SelectedValueChanged += new System.EventHandler(this.comboBox_listado_SelectedValueChanged);
            // 
            // textBox_descripcion
            // 
            this.textBox_descripcion.Location = new System.Drawing.Point(109, 67);
            this.textBox_descripcion.Name = "textBox_descripcion";
            this.textBox_descripcion.Size = new System.Drawing.Size(120, 20);
            this.textBox_descripcion.TabIndex = 2;
            // 
            // label_tipoProdDesc
            // 
            this.label_tipoProdDesc.AutoSize = true;
            this.label_tipoProdDesc.Location = new System.Drawing.Point(25, 70);
            this.label_tipoProdDesc.Name = "label_tipoProdDesc";
            this.label_tipoProdDesc.Size = new System.Drawing.Size(66, 13);
            this.label_tipoProdDesc.TabIndex = 3;
            this.label_tipoProdDesc.Text = "Descripción:";
            // 
            // button_agregar
            // 
            this.button_agregar.Location = new System.Drawing.Point(109, 122);
            this.button_agregar.Name = "button_agregar";
            this.button_agregar.Size = new System.Drawing.Size(120, 23);
            this.button_agregar.TabIndex = 4;
            this.button_agregar.Text = "Agregar";
            this.button_agregar.UseVisualStyleBackColor = true;
            this.button_agregar.Click += new System.EventHandler(this.button_agregar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(253, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(283, 262);
            this.dataGridView1.TabIndex = 5;
            // 
            // button_salir
            // 
            this.button_salir.Location = new System.Drawing.Point(429, 280);
            this.button_salir.Name = "button_salir";
            this.button_salir.Size = new System.Drawing.Size(107, 39);
            this.button_salir.TabIndex = 6;
            this.button_salir.Text = "Salir";
            this.button_salir.UseVisualStyleBackColor = true;
            this.button_salir.Click += new System.EventHandler(this.button_salir_Click);
            // 
            // Tipo_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 328);
            this.Controls.Add(this.button_salir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_agregar);
            this.Controls.Add(this.label_tipoProdDesc);
            this.Controls.Add(this.textBox_descripcion);
            this.Controls.Add(this.comboBox_listado);
            this.Controls.Add(this.checkBox_Modificar);
            this.Name = "Tipo_Producto";
            this.Text = "Tipo_Producto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_Modificar;
        private System.Windows.Forms.ComboBox comboBox_listado;
        private System.Windows.Forms.TextBox textBox_descripcion;
        private System.Windows.Forms.Label label_tipoProdDesc;
        private System.Windows.Forms.Button button_agregar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_salir;
    }
}