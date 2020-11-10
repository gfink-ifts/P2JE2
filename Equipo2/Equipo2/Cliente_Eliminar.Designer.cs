namespace Equipo2
{
    partial class Cliente_Eliminar
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
            this.btn_salir3 = new System.Windows.Forms.Button();
            this.btn_borrarCli = new System.Windows.Forms.Button();
            this.txt_nroCli = new System.Windows.Forms.TextBox();
            this.lbl_numCli = new System.Windows.Forms.Label();
            this.dataGridView_cliente = new System.Windows.Forms.DataGridView();
            this.btn_buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_salir3
            // 
            this.btn_salir3.Location = new System.Drawing.Point(349, 195);
            this.btn_salir3.Name = "btn_salir3";
            this.btn_salir3.Size = new System.Drawing.Size(139, 47);
            this.btn_salir3.TabIndex = 7;
            this.btn_salir3.Text = "SALIR";
            this.btn_salir3.UseVisualStyleBackColor = true;
            this.btn_salir3.Click += new System.EventHandler(this.btn_salir3_Click);
            // 
            // btn_borrarCli
            // 
            this.btn_borrarCli.Location = new System.Drawing.Point(29, 195);
            this.btn_borrarCli.Name = "btn_borrarCli";
            this.btn_borrarCli.Size = new System.Drawing.Size(139, 47);
            this.btn_borrarCli.TabIndex = 6;
            this.btn_borrarCli.Text = "ELIMINAR CLIENTE";
            this.btn_borrarCli.UseVisualStyleBackColor = true;
            this.btn_borrarCli.Click += new System.EventHandler(this.btn_borrarCli_Click);
            // 
            // txt_nroCli
            // 
            this.txt_nroCli.Location = new System.Drawing.Point(159, 31);
            this.txt_nroCli.Name = "txt_nroCli";
            this.txt_nroCli.Size = new System.Drawing.Size(138, 20);
            this.txt_nroCli.TabIndex = 5;
            // 
            // lbl_numCli
            // 
            this.lbl_numCli.AutoSize = true;
            this.lbl_numCli.Location = new System.Drawing.Point(53, 34);
            this.lbl_numCli.Name = "lbl_numCli";
            this.lbl_numCli.Size = new System.Drawing.Size(74, 13);
            this.lbl_numCli.TabIndex = 4;
            this.lbl_numCli.Text = "Nro de Cliente";
            // 
            // dataGridView_cliente
            // 
            this.dataGridView_cliente.AllowUserToAddRows = false;
            this.dataGridView_cliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_cliente.Location = new System.Drawing.Point(29, 77);
            this.dataGridView_cliente.Name = "dataGridView_cliente";
            this.dataGridView_cliente.RowHeadersVisible = false;
            this.dataGridView_cliente.Size = new System.Drawing.Size(459, 90);
            this.dataGridView_cliente.TabIndex = 8;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(362, 19);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(126, 43);
            this.btn_buscar.TabIndex = 17;
            this.btn_buscar.Text = "BUSCAR Cliente";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // Cliente_Eliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 261);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.dataGridView_cliente);
            this.Controls.Add(this.btn_salir3);
            this.Controls.Add(this.btn_borrarCli);
            this.Controls.Add(this.txt_nroCli);
            this.Controls.Add(this.lbl_numCli);
            this.Name = "Cliente_Eliminar";
            this.Text = "Eliminar Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_salir3;
        private System.Windows.Forms.Button btn_borrarCli;
        private System.Windows.Forms.TextBox txt_nroCli;
        private System.Windows.Forms.Label lbl_numCli;
        private System.Windows.Forms.DataGridView dataGridView_cliente;
        private System.Windows.Forms.Button btn_buscar;
    }
}