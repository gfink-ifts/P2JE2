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
            this.SuspendLayout();
            // 
            // button_tipoProducto
            // 
            this.button_tipoProducto.Location = new System.Drawing.Point(12, 12);
            this.button_tipoProducto.Name = "button_tipoProducto";
            this.button_tipoProducto.Size = new System.Drawing.Size(75, 52);
            this.button_tipoProducto.TabIndex = 0;
            this.button_tipoProducto.Text = "Agregar Tipo Producto";
            this.button_tipoProducto.UseVisualStyleBackColor = true;
            this.button_tipoProducto.Click += new System.EventHandler(this.button_tipoProducto_Click);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_tipoProducto);
            this.Name = "Productos";
            this.Text = "Productos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_tipoProducto;
    }
}