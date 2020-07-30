namespace Rodriguez.Vista
{
    partial class V_ReporteBoleta
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
            this.crystalReportViewerBoleta = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerBoleta
            // 
            this.crystalReportViewerBoleta.ActiveViewIndex = -1;
            this.crystalReportViewerBoleta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerBoleta.CachedPageNumberPerDoc = 10;
            this.crystalReportViewerBoleta.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerBoleta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerBoleta.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerBoleta.Name = "crystalReportViewerBoleta";
            this.crystalReportViewerBoleta.Size = new System.Drawing.Size(900, 458);
            this.crystalReportViewerBoleta.TabIndex = 0;
            // 
            // FrmReporteBoleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 458);
            this.Controls.Add(this.crystalReportViewerBoleta);
            this.Name = "FrmReporteBoleta";
            this.Text = "Boleta";
            this.Load += new System.EventHandler(this.FrmReporteBoleta_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerBoleta;
    }
}