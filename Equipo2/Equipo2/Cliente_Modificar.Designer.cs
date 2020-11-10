namespace Equipo2
{
    partial class Cliente_Modificar
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
            this.txt_dniCli = new System.Windows.Forms.TextBox();
            this.txt_direCli = new System.Windows.Forms.TextBox();
            this.txt_apeCli = new System.Windows.Forms.TextBox();
            this.txt_nomCli = new System.Windows.Forms.TextBox();
            this.btn_editarCli = new System.Windows.Forms.Button();
            this.lbl_dniCli4 = new System.Windows.Forms.Label();
            this.lbl_apeCli4 = new System.Windows.Forms.Label();
            this.lbl_direCli = new System.Windows.Forms.Label();
            this.lbl_nomCli4 = new System.Windows.Forms.Label();
            this.btn_salir4 = new System.Windows.Forms.Button();
            this.dataGridView_dataCliente = new System.Windows.Forms.DataGridView();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.lbl_nroCli4 = new System.Windows.Forms.Label();
            this.txt_nroCli = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_nroCliente = new System.Windows.Forms.Label();
            this.groupBox_dataActual = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dataCliente)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox_dataActual.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_dniCli
            // 
            this.txt_dniCli.Location = new System.Drawing.Point(129, 170);
            this.txt_dniCli.Name = "txt_dniCli";
            this.txt_dniCli.Size = new System.Drawing.Size(137, 20);
            this.txt_dniCli.TabIndex = 27;
            // 
            // txt_direCli
            // 
            this.txt_direCli.Location = new System.Drawing.Point(129, 135);
            this.txt_direCli.Name = "txt_direCli";
            this.txt_direCli.Size = new System.Drawing.Size(137, 20);
            this.txt_direCli.TabIndex = 26;
            // 
            // txt_apeCli
            // 
            this.txt_apeCli.Location = new System.Drawing.Point(129, 99);
            this.txt_apeCli.Name = "txt_apeCli";
            this.txt_apeCli.Size = new System.Drawing.Size(137, 20);
            this.txt_apeCli.TabIndex = 25;
            // 
            // txt_nomCli
            // 
            this.txt_nomCli.Location = new System.Drawing.Point(129, 57);
            this.txt_nomCli.Name = "txt_nomCli";
            this.txt_nomCli.Size = new System.Drawing.Size(137, 20);
            this.txt_nomCli.TabIndex = 24;
            // 
            // btn_editarCli
            // 
            this.btn_editarCli.Location = new System.Drawing.Point(15, 369);
            this.btn_editarCli.Name = "btn_editarCli";
            this.btn_editarCli.Size = new System.Drawing.Size(129, 43);
            this.btn_editarCli.TabIndex = 23;
            this.btn_editarCli.Text = "Guardar Datos";
            this.btn_editarCli.UseVisualStyleBackColor = true;
            this.btn_editarCli.Click += new System.EventHandler(this.btn_editarCli_Click);
            // 
            // lbl_dniCli4
            // 
            this.lbl_dniCli4.AutoSize = true;
            this.lbl_dniCli4.Location = new System.Drawing.Point(12, 173);
            this.lbl_dniCli4.Name = "lbl_dniCli4";
            this.lbl_dniCli4.Size = new System.Drawing.Size(29, 13);
            this.lbl_dniCli4.TabIndex = 22;
            this.lbl_dniCli4.Text = "DNI ";
            // 
            // lbl_apeCli4
            // 
            this.lbl_apeCli4.AutoSize = true;
            this.lbl_apeCli4.Location = new System.Drawing.Point(12, 99);
            this.lbl_apeCli4.Name = "lbl_apeCli4";
            this.lbl_apeCli4.Size = new System.Drawing.Size(96, 13);
            this.lbl_apeCli4.TabIndex = 21;
            this.lbl_apeCli4.Text = "Apellido del Cliente";
            // 
            // lbl_direCli
            // 
            this.lbl_direCli.AutoSize = true;
            this.lbl_direCli.Location = new System.Drawing.Point(12, 138);
            this.lbl_direCli.Name = "lbl_direCli";
            this.lbl_direCli.Size = new System.Drawing.Size(104, 13);
            this.lbl_direCli.TabIndex = 20;
            this.lbl_direCli.Text = "Direccion del Cliente";
            // 
            // lbl_nomCli4
            // 
            this.lbl_nomCli4.AutoSize = true;
            this.lbl_nomCli4.Location = new System.Drawing.Point(12, 64);
            this.lbl_nomCli4.Name = "lbl_nomCli4";
            this.lbl_nomCli4.Size = new System.Drawing.Size(96, 13);
            this.lbl_nomCli4.TabIndex = 19;
            this.lbl_nomCli4.Text = "Nombre del Cliente";
            // 
            // btn_salir4
            // 
            this.btn_salir4.Location = new System.Drawing.Point(459, 369);
            this.btn_salir4.Name = "btn_salir4";
            this.btn_salir4.Size = new System.Drawing.Size(126, 43);
            this.btn_salir4.TabIndex = 18;
            this.btn_salir4.Text = "Cerrar";
            this.btn_salir4.UseVisualStyleBackColor = true;
            this.btn_salir4.Click += new System.EventHandler(this.btn_salir4_Click);
            // 
            // dataGridView_dataCliente
            // 
            this.dataGridView_dataCliente.AllowUserToAddRows = false;
            this.dataGridView_dataCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_dataCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_dataCliente.Location = new System.Drawing.Point(6, 26);
            this.dataGridView_dataCliente.Name = "dataGridView_dataCliente";
            this.dataGridView_dataCliente.RowHeadersVisible = false;
            this.dataGridView_dataCliente.Size = new System.Drawing.Size(559, 68);
            this.dataGridView_dataCliente.TabIndex = 17;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(459, 12);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(126, 43);
            this.btn_buscar.TabIndex = 16;
            this.btn_buscar.Text = "BUSCAR Cliente";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // lbl_nroCli4
            // 
            this.lbl_nroCli4.AutoSize = true;
            this.lbl_nroCli4.Location = new System.Drawing.Point(68, 30);
            this.lbl_nroCli4.Name = "lbl_nroCli4";
            this.lbl_nroCli4.Size = new System.Drawing.Size(76, 13);
            this.lbl_nroCli4.TabIndex = 15;
            this.lbl_nroCli4.Text = "Nro del Cliente";
            // 
            // txt_nroCli
            // 
            this.txt_nroCli.Location = new System.Drawing.Point(173, 27);
            this.txt_nroCli.Name = "txt_nroCli";
            this.txt_nroCli.Size = new System.Drawing.Size(122, 20);
            this.txt_nroCli.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_nroCliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl_direCli);
            this.groupBox1.Controls.Add(this.txt_dniCli);
            this.groupBox1.Controls.Add(this.lbl_nomCli4);
            this.groupBox1.Controls.Add(this.txt_direCli);
            this.groupBox1.Controls.Add(this.lbl_apeCli4);
            this.groupBox1.Controls.Add(this.txt_apeCli);
            this.groupBox1.Controls.Add(this.lbl_dniCli4);
            this.groupBox1.Controls.Add(this.txt_nomCli);
            this.groupBox1.Location = new System.Drawing.Point(162, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 205);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos a Actualizar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Nro. Cliente:";
            // 
            // label_nroCliente
            // 
            this.label_nroCliente.AutoSize = true;
            this.label_nroCliente.Location = new System.Drawing.Point(129, 29);
            this.label_nroCliente.Name = "label_nroCliente";
            this.label_nroCliente.Size = new System.Drawing.Size(10, 13);
            this.label_nroCliente.TabIndex = 29;
            this.label_nroCliente.Text = "-";
            // 
            // groupBox_dataActual
            // 
            this.groupBox_dataActual.Controls.Add(this.dataGridView_dataCliente);
            this.groupBox_dataActual.Location = new System.Drawing.Point(15, 62);
            this.groupBox_dataActual.Name = "groupBox_dataActual";
            this.groupBox_dataActual.Size = new System.Drawing.Size(571, 100);
            this.groupBox_dataActual.TabIndex = 29;
            this.groupBox_dataActual.TabStop = false;
            this.groupBox_dataActual.Text = "Datos del Cliente en el Sistema";
            // 
            // Cliente_Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 424);
            this.Controls.Add(this.groupBox_dataActual);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_editarCli);
            this.Controls.Add(this.btn_salir4);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.lbl_nroCli4);
            this.Controls.Add(this.txt_nroCli);
            this.Name = "Cliente_Modificar";
            this.Text = "Modificar Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dataCliente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_dataActual.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_dniCli;
        private System.Windows.Forms.TextBox txt_direCli;
        private System.Windows.Forms.TextBox txt_apeCli;
        private System.Windows.Forms.TextBox txt_nomCli;
        private System.Windows.Forms.Button btn_editarCli;
        private System.Windows.Forms.Label lbl_dniCli4;
        private System.Windows.Forms.Label lbl_apeCli4;
        private System.Windows.Forms.Label lbl_direCli;
        private System.Windows.Forms.Label lbl_nomCli4;
        private System.Windows.Forms.Button btn_salir4;
        private System.Windows.Forms.DataGridView dataGridView_dataCliente;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label lbl_nroCli4;
        private System.Windows.Forms.TextBox txt_nroCli;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_nroCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_dataActual;
    }
}