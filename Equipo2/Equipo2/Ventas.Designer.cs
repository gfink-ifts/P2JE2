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
            this.groupBox_datosVenta = new System.Windows.Forms.GroupBox();
            this.dataGridView_ventas = new System.Windows.Forms.DataGridView();
            this.button_nuevaVenta = new System.Windows.Forms.Button();
            this.button_cerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ventas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_datosVenta
            // 
            this.groupBox_datosVenta.Location = new System.Drawing.Point(13, 13);
            this.groupBox_datosVenta.Name = "groupBox_datosVenta";
            this.groupBox_datosVenta.Size = new System.Drawing.Size(641, 173);
            this.groupBox_datosVenta.TabIndex = 0;
            this.groupBox_datosVenta.TabStop = false;
            this.groupBox_datosVenta.Text = "Datos de la Venta";
            // 
            // dataGridView_ventas
            // 
            this.dataGridView_ventas.AllowUserToAddRows = false;
            this.dataGridView_ventas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ventas.Location = new System.Drawing.Point(13, 192);
            this.dataGridView_ventas.Name = "dataGridView_ventas";
            this.dataGridView_ventas.RowHeadersVisible = false;
            this.dataGridView_ventas.Size = new System.Drawing.Size(775, 246);
            this.dataGridView_ventas.TabIndex = 1;
            // 
            // button_nuevaVenta
            // 
            this.button_nuevaVenta.Location = new System.Drawing.Point(692, 56);
            this.button_nuevaVenta.Name = "button_nuevaVenta";
            this.button_nuevaVenta.Size = new System.Drawing.Size(75, 50);
            this.button_nuevaVenta.TabIndex = 2;
            this.button_nuevaVenta.Text = "Nueva Venta";
            this.button_nuevaVenta.UseVisualStyleBackColor = true;
            this.button_nuevaVenta.Click += new System.EventHandler(this.button_nuevaVenta_Click);
            // 
            // button_cerrar
            // 
            this.button_cerrar.Location = new System.Drawing.Point(692, 451);
            this.button_cerrar.Name = "button_cerrar";
            this.button_cerrar.Size = new System.Drawing.Size(84, 23);
            this.button_cerrar.TabIndex = 3;
            this.button_cerrar.Text = "Cerrar";
            this.button_cerrar.UseVisualStyleBackColor = true;
            this.button_cerrar.Click += new System.EventHandler(this.button_cerrar_Click);
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.button_cerrar);
            this.Controls.Add(this.button_nuevaVenta);
            this.Controls.Add(this.dataGridView_ventas);
            this.Controls.Add(this.groupBox_datosVenta);
            this.Name = "Ventas";
            this.Text = "Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ventas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_datosVenta;
        private System.Windows.Forms.DataGridView dataGridView_ventas;
        private System.Windows.Forms.Button button_nuevaVenta;
        private System.Windows.Forms.Button button_cerrar;
    }
}