namespace Equipo2
{
    partial class Clientes
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
            this.btn_altaCliente = new System.Windows.Forms.Button();
            this.lbl_dniCliente = new System.Windows.Forms.Label();
            this.lbl_direCliente = new System.Windows.Forms.Label();
            this.lbl_apeCliente = new System.Windows.Forms.Label();
            this.lbl_nombreCli = new System.Windows.Forms.Label();
            this.txt_direccCliente = new System.Windows.Forms.TextBox();
            this.txt_apeCliente = new System.Windows.Forms.TextBox();
            this.txt_nombreCliente = new System.Windows.Forms.TextBox();
            this.txt_dniCliente = new System.Windows.Forms.TextBox();
            this.dataGridView_clientes = new System.Windows.Forms.DataGridView();
            this.btn_modifCli = new System.Windows.Forms.Button();
            this.btn_borrarCli2 = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_altaCliente
            // 
            this.btn_altaCliente.Location = new System.Drawing.Point(125, 196);
            this.btn_altaCliente.Name = "btn_altaCliente";
            this.btn_altaCliente.Size = new System.Drawing.Size(177, 54);
            this.btn_altaCliente.TabIndex = 19;
            this.btn_altaCliente.Text = "AGREGAR CLIENTE";
            this.btn_altaCliente.UseVisualStyleBackColor = true;
            this.btn_altaCliente.Click += new System.EventHandler(this.btn_altaCliente_Click);
            // 
            // lbl_dniCliente
            // 
            this.lbl_dniCliente.AutoSize = true;
            this.lbl_dniCliente.Location = new System.Drawing.Point(31, 162);
            this.lbl_dniCliente.Name = "lbl_dniCliente";
            this.lbl_dniCliente.Size = new System.Drawing.Size(26, 13);
            this.lbl_dniCliente.TabIndex = 18;
            this.lbl_dniCliente.Text = "DNI";
            // 
            // lbl_direCliente
            // 
            this.lbl_direCliente.AutoSize = true;
            this.lbl_direCliente.Location = new System.Drawing.Point(31, 119);
            this.lbl_direCliente.Name = "lbl_direCliente";
            this.lbl_direCliente.Size = new System.Drawing.Size(55, 13);
            this.lbl_direCliente.TabIndex = 17;
            this.lbl_direCliente.Text = "Direccion ";
            // 
            // lbl_apeCliente
            // 
            this.lbl_apeCliente.AutoSize = true;
            this.lbl_apeCliente.Location = new System.Drawing.Point(31, 77);
            this.lbl_apeCliente.Name = "lbl_apeCliente";
            this.lbl_apeCliente.Size = new System.Drawing.Size(96, 13);
            this.lbl_apeCliente.TabIndex = 16;
            this.lbl_apeCliente.Text = "Apellido del Cliente";
            // 
            // lbl_nombreCli
            // 
            this.lbl_nombreCli.AutoSize = true;
            this.lbl_nombreCli.Location = new System.Drawing.Point(31, 34);
            this.lbl_nombreCli.Name = "lbl_nombreCli";
            this.lbl_nombreCli.Size = new System.Drawing.Size(96, 13);
            this.lbl_nombreCli.TabIndex = 15;
            this.lbl_nombreCli.Text = "Nombre del Cliente";
            // 
            // txt_direccCliente
            // 
            this.txt_direccCliente.Location = new System.Drawing.Point(189, 112);
            this.txt_direccCliente.Name = "txt_direccCliente";
            this.txt_direccCliente.Size = new System.Drawing.Size(113, 20);
            this.txt_direccCliente.TabIndex = 14;
            // 
            // txt_apeCliente
            // 
            this.txt_apeCliente.Location = new System.Drawing.Point(189, 70);
            this.txt_apeCliente.Name = "txt_apeCliente";
            this.txt_apeCliente.Size = new System.Drawing.Size(113, 20);
            this.txt_apeCliente.TabIndex = 13;
            // 
            // txt_nombreCliente
            // 
            this.txt_nombreCliente.Location = new System.Drawing.Point(189, 27);
            this.txt_nombreCliente.Name = "txt_nombreCliente";
            this.txt_nombreCliente.Size = new System.Drawing.Size(113, 20);
            this.txt_nombreCliente.TabIndex = 12;
            // 
            // txt_dniCliente
            // 
            this.txt_dniCliente.Location = new System.Drawing.Point(189, 155);
            this.txt_dniCliente.Name = "txt_dniCliente";
            this.txt_dniCliente.Size = new System.Drawing.Size(113, 20);
            this.txt_dniCliente.TabIndex = 11;
            // 
            // dataGridView_clientes
            // 
            this.dataGridView_clientes.AllowUserToAddRows = false;
            this.dataGridView_clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_clientes.Location = new System.Drawing.Point(329, 27);
            this.dataGridView_clientes.Name = "dataGridView_clientes";
            this.dataGridView_clientes.RowHeadersVisible = false;
            this.dataGridView_clientes.Size = new System.Drawing.Size(459, 223);
            this.dataGridView_clientes.TabIndex = 20;
            // 
            // btn_modifCli
            // 
            this.btn_modifCli.Location = new System.Drawing.Point(34, 362);
            this.btn_modifCli.Name = "btn_modifCli";
            this.btn_modifCli.Size = new System.Drawing.Size(113, 54);
            this.btn_modifCli.TabIndex = 22;
            this.btn_modifCli.Text = "Modificar Datos del Cliente";
            this.btn_modifCli.UseVisualStyleBackColor = true;
            this.btn_modifCli.Click += new System.EventHandler(this.btn_modifCli_Click);
            // 
            // btn_borrarCli2
            // 
            this.btn_borrarCli2.Location = new System.Drawing.Point(189, 362);
            this.btn_borrarCli2.Name = "btn_borrarCli2";
            this.btn_borrarCli2.Size = new System.Drawing.Size(113, 54);
            this.btn_borrarCli2.TabIndex = 21;
            this.btn_borrarCli2.Text = "Eliminar Cliente";
            this.btn_borrarCli2.UseVisualStyleBackColor = true;
            this.btn_borrarCli2.Click += new System.EventHandler(this.btn_borrarCli2_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(710, 362);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(78, 54);
            this.btn_cerrar.TabIndex = 23;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_modifCli);
            this.Controls.Add(this.btn_borrarCli2);
            this.Controls.Add(this.dataGridView_clientes);
            this.Controls.Add(this.btn_altaCliente);
            this.Controls.Add(this.lbl_dniCliente);
            this.Controls.Add(this.lbl_direCliente);
            this.Controls.Add(this.lbl_apeCliente);
            this.Controls.Add(this.lbl_nombreCli);
            this.Controls.Add(this.txt_direccCliente);
            this.Controls.Add(this.txt_apeCliente);
            this.Controls.Add(this.txt_nombreCliente);
            this.Controls.Add(this.txt_dniCliente);
            this.Name = "Clientes";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_altaCliente;
        private System.Windows.Forms.Label lbl_dniCliente;
        private System.Windows.Forms.Label lbl_direCliente;
        private System.Windows.Forms.Label lbl_apeCliente;
        private System.Windows.Forms.Label lbl_nombreCli;
        private System.Windows.Forms.TextBox txt_direccCliente;
        private System.Windows.Forms.TextBox txt_apeCliente;
        private System.Windows.Forms.TextBox txt_nombreCliente;
        private System.Windows.Forms.TextBox txt_dniCliente;
        private System.Windows.Forms.DataGridView dataGridView_clientes;
        private System.Windows.Forms.Button btn_modifCli;
        private System.Windows.Forms.Button btn_borrarCli2;
        private System.Windows.Forms.Button btn_cerrar;
    }
}