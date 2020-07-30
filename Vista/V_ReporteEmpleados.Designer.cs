namespace Rodriguez.Vista
{
    partial class V_ReporteEmpleados
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
            this.crystalReportViewerEmpleados = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerEmpleados
            // 
            this.crystalReportViewerEmpleados.ActiveViewIndex = -1;
            this.crystalReportViewerEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerEmpleados.CachedPageNumberPerDoc = 10;
            this.crystalReportViewerEmpleados.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerEmpleados.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerEmpleados.Name = "crystalReportViewerEmpleados";
            this.crystalReportViewerEmpleados.Size = new System.Drawing.Size(819, 403);
            this.crystalReportViewerEmpleados.TabIndex = 0;
            // 
            // FrmReporteEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 403);
            this.Controls.Add(this.crystalReportViewerEmpleados);
            this.Name = "FrmReporteEmpleados";
            this.Text = "Reporte Empleados";
            this.Load += new System.EventHandler(this.ReporteEmpleados_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerEmpleados;
    }
}