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
            this.label_cliente = new System.Windows.Forms.Label();
            this.txt_numCli = new System.Windows.Forms.TextBox();
            this.label_fechaInicio = new System.Windows.Forms.Label();
            this.dateTimePicker_inicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_fin = new System.Windows.Forms.DateTimePicker();
            this.label_fechaFin = new System.Windows.Forms.Label();
            this.button_buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_resultados)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_resultados
            // 
            this.dataGridView_resultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_resultados.Location = new System.Drawing.Point(13, 107);
            this.dataGridView_resultados.Name = "dataGridView_resultados";
            this.dataGridView_resultados.Size = new System.Drawing.Size(775, 331);
            this.dataGridView_resultados.TabIndex = 0;
            // 
            // label_cliente
            // 
            this.label_cliente.AutoSize = true;
            this.label_cliente.Location = new System.Drawing.Point(27, 38);
            this.label_cliente.Name = "label_cliente";
            this.label_cliente.Size = new System.Drawing.Size(42, 13);
            this.label_cliente.TabIndex = 1;
            this.label_cliente.Text = "Cliente:";
            // 
            // txt_numCli
            // 
            this.txt_numCli.Location = new System.Drawing.Point(75, 34);
            this.txt_numCli.Name = "txt_numCli";
            this.txt_numCli.Size = new System.Drawing.Size(100, 20);
            this.txt_numCli.TabIndex = 2;
            // 
            // label_fechaInicio
            // 
            this.label_fechaInicio.AutoSize = true;
            this.label_fechaInicio.Location = new System.Drawing.Point(211, 37);
            this.label_fechaInicio.Name = "label_fechaInicio";
            this.label_fechaInicio.Size = new System.Drawing.Size(68, 13);
            this.label_fechaInicio.TabIndex = 3;
            this.label_fechaInicio.Text = "Fecha Inicio:";
            // 
            // dateTimePicker_inicio
            // 
            this.dateTimePicker_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_inicio.Location = new System.Drawing.Point(285, 33);
            this.dateTimePicker_inicio.Name = "dateTimePicker_inicio";
            this.dateTimePicker_inicio.Size = new System.Drawing.Size(102, 20);
            this.dateTimePicker_inicio.TabIndex = 4;
            // 
            // dateTimePicker_fin
            // 
            this.dateTimePicker_fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_fin.Location = new System.Drawing.Point(517, 34);
            this.dateTimePicker_fin.Name = "dateTimePicker_fin";
            this.dateTimePicker_fin.Size = new System.Drawing.Size(102, 20);
            this.dateTimePicker_fin.TabIndex = 6;
            // 
            // label_fechaFin
            // 
            this.label_fechaFin.AutoSize = true;
            this.label_fechaFin.Location = new System.Drawing.Point(443, 38);
            this.label_fechaFin.Name = "label_fechaFin";
            this.label_fechaFin.Size = new System.Drawing.Size(57, 13);
            this.label_fechaFin.TabIndex = 5;
            this.label_fechaFin.Text = "Fecha Fin:";
            // 
            // button_buscar
            // 
            this.button_buscar.Location = new System.Drawing.Point(672, 33);
            this.button_buscar.Name = "button_buscar";
            this.button_buscar.Size = new System.Drawing.Size(75, 23);
            this.button_buscar.TabIndex = 7;
            this.button_buscar.Text = "Buscar";
            this.button_buscar.UseVisualStyleBackColor = true;
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_buscar);
            this.Controls.Add(this.dateTimePicker_fin);
            this.Controls.Add(this.label_fechaFin);
            this.Controls.Add(this.dateTimePicker_inicio);
            this.Controls.Add(this.label_fechaInicio);
            this.Controls.Add(this.txt_numCli);
            this.Controls.Add(this.label_cliente);
            this.Controls.Add(this.dataGridView_resultados);
            this.Name = "Reportes";
            this.Text = "Reportes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_resultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_resultados;
        private System.Windows.Forms.Label label_cliente;
        private System.Windows.Forms.TextBox txt_numCli;
        private System.Windows.Forms.Label label_fechaInicio;
        private System.Windows.Forms.DateTimePicker dateTimePicker_inicio;
        private System.Windows.Forms.DateTimePicker dateTimePicker_fin;
        private System.Windows.Forms.Label label_fechaFin;
        private System.Windows.Forms.Button button_buscar;
    }
}