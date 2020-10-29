namespace Equipo2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_cliente = new System.Windows.Forms.Button();
            this.button_productos = new System.Windows.Forms.Button();
            this.button_ventas = new System.Windows.Forms.Button();
            this.button_cerrar = new System.Windows.Forms.Button();
            this.button_reportes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_cliente
            // 
            this.button_cliente.Location = new System.Drawing.Point(221, 74);
            this.button_cliente.Name = "button_cliente";
            this.button_cliente.Size = new System.Drawing.Size(75, 23);
            this.button_cliente.TabIndex = 0;
            this.button_cliente.Text = "Clientes";
            this.button_cliente.UseVisualStyleBackColor = true;
            // 
            // button_productos
            // 
            this.button_productos.Location = new System.Drawing.Point(221, 126);
            this.button_productos.Name = "button_productos";
            this.button_productos.Size = new System.Drawing.Size(75, 23);
            this.button_productos.TabIndex = 1;
            this.button_productos.Text = "Productos";
            this.button_productos.UseVisualStyleBackColor = true;
            // 
            // button_ventas
            // 
            this.button_ventas.Location = new System.Drawing.Point(221, 172);
            this.button_ventas.Name = "button_ventas";
            this.button_ventas.Size = new System.Drawing.Size(75, 23);
            this.button_ventas.TabIndex = 2;
            this.button_ventas.Text = "Ventas";
            this.button_ventas.UseVisualStyleBackColor = true;
            // 
            // button_cerrar
            // 
            this.button_cerrar.Location = new System.Drawing.Point(221, 272);
            this.button_cerrar.Name = "button_cerrar";
            this.button_cerrar.Size = new System.Drawing.Size(75, 23);
            this.button_cerrar.TabIndex = 3;
            this.button_cerrar.Text = "Salir";
            this.button_cerrar.UseVisualStyleBackColor = true;
            // 
            // button_reportes
            // 
            this.button_reportes.Location = new System.Drawing.Point(221, 223);
            this.button_reportes.Name = "button_reportes";
            this.button_reportes.Size = new System.Drawing.Size(75, 23);
            this.button_reportes.TabIndex = 4;
            this.button_reportes.Text = "Reportes";
            this.button_reportes.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 426);
            this.Controls.Add(this.button_reportes);
            this.Controls.Add(this.button_cerrar);
            this.Controls.Add(this.button_ventas);
            this.Controls.Add(this.button_productos);
            this.Controls.Add(this.button_cliente);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_cliente;
        private System.Windows.Forms.Button button_productos;
        private System.Windows.Forms.Button button_ventas;
        private System.Windows.Forms.Button button_cerrar;
        private System.Windows.Forms.Button button_reportes;
    }
}

