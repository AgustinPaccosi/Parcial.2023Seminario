namespace Jardines2023.Windows
{
    partial class frmPrincipal
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
            this.CategoriasButton = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCompras = new System.Windows.Forms.Button();
            this.VentasButton = new System.Windows.Forms.Button();
            this.ProductosButton = new System.Windows.Forms.Button();
            this.ProveedoresButton = new System.Windows.Forms.Button();
            this.ClientesButton = new System.Windows.Forms.Button();
            this.CiudadesButton = new System.Windows.Forms.Button();
            this.b = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CategoriasButton
            // 
            this.CategoriasButton.Image = global::Jardines2023.Windows.Properties.Resources.categorize_50px;
            this.CategoriasButton.Location = new System.Drawing.Point(79, 201);
            this.CategoriasButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CategoriasButton.Name = "CategoriasButton";
            this.CategoriasButton.Size = new System.Drawing.Size(196, 94);
            this.CategoriasButton.TabIndex = 12;
            this.CategoriasButton.Text = "Categorías";
            this.CategoriasButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CategoriasButton.UseVisualStyleBackColor = true;
            this.CategoriasButton.Click += new System.EventHandler(this.CategoriasButton_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::Jardines2023.Windows.Properties.Resources.shutdown_48px;
            this.btnSalir.Location = new System.Drawing.Point(791, 446);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(196, 94);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCompras
            // 
            this.btnCompras.Image = global::Jardines2023.Windows.Properties.Resources.sales_channels_50px;
            this.btnCompras.Location = new System.Drawing.Point(79, 343);
            this.btnCompras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(196, 94);
            this.btnCompras.TabIndex = 13;
            this.btnCompras.Text = "Compras";
            this.btnCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCompras.UseVisualStyleBackColor = true;
            // 
            // VentasButton
            // 
            this.VentasButton.Image = global::Jardines2023.Windows.Properties.Resources.cash_register_50px;
            this.VentasButton.Location = new System.Drawing.Point(321, 343);
            this.VentasButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.VentasButton.Name = "VentasButton";
            this.VentasButton.Size = new System.Drawing.Size(196, 94);
            this.VentasButton.TabIndex = 13;
            this.VentasButton.Text = "Ventas";
            this.VentasButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.VentasButton.UseVisualStyleBackColor = true;
            this.VentasButton.Click += new System.EventHandler(this.VentasButton_Click);
            // 
            // ProductosButton
            // 
            this.ProductosButton.Image = global::Jardines2023.Windows.Properties.Resources.used_product_50px;
            this.ProductosButton.Location = new System.Drawing.Point(565, 201);
            this.ProductosButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProductosButton.Name = "ProductosButton";
            this.ProductosButton.Size = new System.Drawing.Size(196, 94);
            this.ProductosButton.TabIndex = 14;
            this.ProductosButton.Text = "Productos";
            this.ProductosButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ProductosButton.UseVisualStyleBackColor = true;
            this.ProductosButton.Click += new System.EventHandler(this.ProductosButton_Click);
            // 
            // ProveedoresButton
            // 
            this.ProveedoresButton.Image = global::Jardines2023.Windows.Properties.Resources.customer_50px;
            this.ProveedoresButton.Location = new System.Drawing.Point(321, 201);
            this.ProveedoresButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProveedoresButton.Name = "ProveedoresButton";
            this.ProveedoresButton.Size = new System.Drawing.Size(196, 94);
            this.ProveedoresButton.TabIndex = 15;
            this.ProveedoresButton.Text = "Proveedores";
            this.ProveedoresButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ProveedoresButton.UseVisualStyleBackColor = true;
            this.ProveedoresButton.Click += new System.EventHandler(this.ProveedoresButton_Click);
            // 
            // ClientesButton
            // 
            this.ClientesButton.Image = global::Jardines2023.Windows.Properties.Resources.client_management_50px;
            this.ClientesButton.Location = new System.Drawing.Point(565, 57);
            this.ClientesButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ClientesButton.Name = "ClientesButton";
            this.ClientesButton.Size = new System.Drawing.Size(196, 94);
            this.ClientesButton.TabIndex = 16;
            this.ClientesButton.Text = "Clientes";
            this.ClientesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ClientesButton.UseVisualStyleBackColor = true;
            this.ClientesButton.Click += new System.EventHandler(this.ClientesButton_Click);
            // 
            // CiudadesButton
            // 
            this.CiudadesButton.Image = global::Jardines2023.Windows.Properties.Resources.city_50px;
            this.CiudadesButton.Location = new System.Drawing.Point(321, 57);
            this.CiudadesButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CiudadesButton.Name = "CiudadesButton";
            this.CiudadesButton.Size = new System.Drawing.Size(196, 94);
            this.CiudadesButton.TabIndex = 17;
            this.CiudadesButton.Text = "Ciudades";
            this.CiudadesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CiudadesButton.UseVisualStyleBackColor = true;
            this.CiudadesButton.Click += new System.EventHandler(this.CiudadesButton_Click);
            // 
            // b
            // 
            this.b.Image = global::Jardines2023.Windows.Properties.Resources.america_50px;
            this.b.Location = new System.Drawing.Point(79, 57);
            this.b.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(196, 94);
            this.b.TabIndex = 18;
            this.b.Text = "Países";
            this.b.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b.UseVisualStyleBackColor = true;
            this.b.Click += new System.EventHandler(this.PaisesButton_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.CategoriasButton);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCompras);
            this.Controls.Add(this.VentasButton);
            this.Controls.Add(this.ProductosButton);
            this.Controls.Add(this.ProveedoresButton);
            this.Controls.Add(this.ClientesButton);
            this.Controls.Add(this.CiudadesButton);
            this.Controls.Add(this.b);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CategoriasButton;
        private System.Windows.Forms.Button VentasButton;
        private System.Windows.Forms.Button ProductosButton;
        private System.Windows.Forms.Button ProveedoresButton;
        private System.Windows.Forms.Button ClientesButton;
        private System.Windows.Forms.Button CiudadesButton;
        private System.Windows.Forms.Button b;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCompras;
    }
}

