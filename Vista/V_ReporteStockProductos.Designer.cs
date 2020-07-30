namespace Rodriguez.Vista
{
    partial class V_ReporteStockProductos
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
            this.crvReporteStockProductos = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvReporteStockProductos
            // 
            this.crvReporteStockProductos.ActiveViewIndex = -1;
            this.crvReporteStockProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvReporteStockProductos.CachedPageNumberPerDoc = 10;
            this.crvReporteStockProductos.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvReporteStockProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvReporteStockProductos.Location = new System.Drawing.Point(0, 0);
            this.crvReporteStockProductos.Name = "crvReporteStockProductos";
            this.crvReporteStockProductos.Size = new System.Drawing.Size(982, 532);
            this.crvReporteStockProductos.TabIndex = 0;
            // 
            // FrmReporteStockProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 532);
            this.Controls.Add(this.crvReporteStockProductos);
            this.Name = "FrmReporteStockProductos";
            this.Text = "Reporte Stock Productos";
            this.Load += new System.EventHandler(this.FrmReporteStockProductos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvReporteStockProductos;

    }
}