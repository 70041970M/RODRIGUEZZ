namespace Rodriguez.Vista
{
    partial class V_MenuVendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_MenuVendedor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosSinStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boletasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etiquetaRol = new System.Windows.Forms.StatusStrip();
            this.etiquetaDNI = new System.Windows.Forms.ToolStripStatusLabel();
            this.etiquetaApellidos = new System.Windows.Forms.ToolStripStatusLabel();
            this.etiquetaNombres = new System.Windows.Forms.ToolStripStatusLabel();
            this.etiquetaCargo = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.etiquetaRol.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.buscarToolStripMenuItem,
            this.seguridadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(947, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantToolStripMenuItem
            // 
            this.mantToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.productoToolStripMenuItem});
            this.mantToolStripMenuItem.Name = "mantToolStripMenuItem";
            this.mantToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mantToolStripMenuItem.Text = "Mantenimiento";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.productoToolStripMenuItem.Text = "Producto";
            this.productoToolStripMenuItem.Click += new System.EventHandler(this.productoToolStripMenuItem_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventaToolStripMenuItem});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // ventaToolStripMenuItem
            // 
            this.ventaToolStripMenuItem.Name = "ventaToolStripMenuItem";
            this.ventaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ventaToolStripMenuItem.Text = "&Venta";
            this.ventaToolStripMenuItem.Click += new System.EventHandler(this.ventaToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteClientesToolStripMenuItem,
            this.reporteProductosToolStripMenuItem,
            this.productosSinStockToolStripMenuItem,
            this.topProductosToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reporteClientesToolStripMenuItem
            // 
            this.reporteClientesToolStripMenuItem.Name = "reporteClientesToolStripMenuItem";
            this.reporteClientesToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.reporteClientesToolStripMenuItem.Text = "Reporte Clientes";
            this.reporteClientesToolStripMenuItem.Click += new System.EventHandler(this.reporteClientesToolStripMenuItem_Click);
            // 
            // reporteProductosToolStripMenuItem
            // 
            this.reporteProductosToolStripMenuItem.Name = "reporteProductosToolStripMenuItem";
            this.reporteProductosToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.reporteProductosToolStripMenuItem.Text = "Reporte Productos";
            this.reporteProductosToolStripMenuItem.Click += new System.EventHandler(this.reporteProductosToolStripMenuItem_Click);
            // 
            // productosSinStockToolStripMenuItem
            // 
            this.productosSinStockToolStripMenuItem.Name = "productosSinStockToolStripMenuItem";
            this.productosSinStockToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.productosSinStockToolStripMenuItem.Text = "Productos sin Stock";
            this.productosSinStockToolStripMenuItem.Click += new System.EventHandler(this.productosSinStockToolStripMenuItem_Click);
            // 
            // topProductosToolStripMenuItem
            // 
            this.topProductosToolStripMenuItem.Name = "topProductosToolStripMenuItem";
            this.topProductosToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.topProductosToolStripMenuItem.Text = "Top Productos";
            this.topProductosToolStripMenuItem.Click += new System.EventHandler(this.topProductosToolStripMenuItem_Click);
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarContraseñaToolStripMenuItem});
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            this.seguridadToolStripMenuItem.Click += new System.EventHandler(this.seguridadToolStripMenuItem_Click);
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.cambiarContraseñaToolStripMenuItem.Text = "Cambiar Contraseña";
            this.cambiarContraseñaToolStripMenuItem.Click += new System.EventHandler(this.cambiarContraseñaToolStripMenuItem_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boletasToolStripMenuItem,
            this.facturasToolStripMenuItem});
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.buscarToolStripMenuItem.Text = "Buscar";
            // 
            // boletasToolStripMenuItem
            // 
            this.boletasToolStripMenuItem.Name = "boletasToolStripMenuItem";
            this.boletasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.boletasToolStripMenuItem.Text = "Boletas";
            this.boletasToolStripMenuItem.Click += new System.EventHandler(this.boletasToolStripMenuItem_Click);
            // 
            // facturasToolStripMenuItem
            // 
            this.facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            this.facturasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.facturasToolStripMenuItem.Text = "Facturas";
            this.facturasToolStripMenuItem.Click += new System.EventHandler(this.facturasToolStripMenuItem_Click);
            // 
            // etiquetaRol
            // 
            this.etiquetaRol.BackColor = System.Drawing.Color.Black;
            this.etiquetaRol.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaRol.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.etiquetaDNI,
            this.etiquetaApellidos,
            this.etiquetaNombres,
            this.etiquetaCargo});
            this.etiquetaRol.Location = new System.Drawing.Point(0, 519);
            this.etiquetaRol.Name = "etiquetaRol";
            this.etiquetaRol.Size = new System.Drawing.Size(947, 23);
            this.etiquetaRol.TabIndex = 4;
            this.etiquetaRol.Text = "statusStrip1";
            // 
            // etiquetaDNI
            // 
            this.etiquetaDNI.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaDNI.ForeColor = System.Drawing.Color.LightGray;
            this.etiquetaDNI.Name = "etiquetaDNI";
            this.etiquetaDNI.Size = new System.Drawing.Size(167, 18);
            this.etiquetaDNI.Text = "toolStripStatusLabel1";
            // 
            // etiquetaApellidos
            // 
            this.etiquetaApellidos.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.etiquetaApellidos.ForeColor = System.Drawing.Color.LightGray;
            this.etiquetaApellidos.Name = "etiquetaApellidos";
            this.etiquetaApellidos.Size = new System.Drawing.Size(167, 18);
            this.etiquetaApellidos.Text = "toolStripStatusLabel2";
            // 
            // etiquetaNombres
            // 
            this.etiquetaNombres.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.etiquetaNombres.ForeColor = System.Drawing.Color.LightGray;
            this.etiquetaNombres.Name = "etiquetaNombres";
            this.etiquetaNombres.Size = new System.Drawing.Size(167, 18);
            this.etiquetaNombres.Text = "toolStripStatusLabel3";
            // 
            // etiquetaCargo
            // 
            this.etiquetaCargo.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.etiquetaCargo.ForeColor = System.Drawing.Color.LightGray;
            this.etiquetaCargo.Name = "etiquetaCargo";
            this.etiquetaCargo.Size = new System.Drawing.Size(167, 18);
            this.etiquetaCargo.Text = "toolStripStatusLabel1";
            // 
            // FrmMenuVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(947, 542);
            this.Controls.Add(this.etiquetaRol);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenuVendedor";
            this.Text = "Menu Vendedor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenuVendedor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.etiquetaRol.ResumeLayout(false);
            this.etiquetaRol.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteProductosToolStripMenuItem;
        private System.Windows.Forms.StatusStrip etiquetaRol;
        private System.Windows.Forms.ToolStripStatusLabel etiquetaDNI;
        private System.Windows.Forms.ToolStripStatusLabel etiquetaApellidos;
        private System.Windows.Forms.ToolStripStatusLabel etiquetaNombres;
        private System.Windows.Forms.ToolStripStatusLabel etiquetaCargo;
        private System.Windows.Forms.ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosSinStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boletasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturasToolStripMenuItem;
    }
}