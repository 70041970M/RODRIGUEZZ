namespace Rodriguez.Vista
{
    partial class V_ReporteFactura
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
            this.crystalReportViewerFactura = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerFactura
            // 
            this.crystalReportViewerFactura.ActiveViewIndex = -1;
            this.crystalReportViewerFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerFactura.CachedPageNumberPerDoc = 10;
            this.crystalReportViewerFactura.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerFactura.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerFactura.Name = "crystalReportViewerFactura";
            this.crystalReportViewerFactura.Size = new System.Drawing.Size(790, 584);
            this.crystalReportViewerFactura.TabIndex = 0;
            // 
            // FrmReporteFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 584);
            this.Controls.Add(this.crystalReportViewerFactura);
            this.Name = "FrmReporteFactura";
            this.Text = " Factura";
            this.Load += new System.EventHandler(this.FrmReporteFactura_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerFactura;
    }
}