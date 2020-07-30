namespace Rodriguez.Vista
{
    partial class V_TopProductos
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
            this.crystalTopProductos = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalTopProductos
            // 
            this.crystalTopProductos.ActiveViewIndex = -1;
            this.crystalTopProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalTopProductos.CachedPageNumberPerDoc = 10;
            this.crystalTopProductos.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalTopProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalTopProductos.Location = new System.Drawing.Point(0, 0);
            this.crystalTopProductos.Name = "crystalTopProductos";
            this.crystalTopProductos.Size = new System.Drawing.Size(790, 491);
            this.crystalTopProductos.TabIndex = 0;
            // 
            // FrmTopProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 491);
            this.Controls.Add(this.crystalTopProductos);
            this.Name = "FrmTopProductos";
            this.Text = "Top Productos mas Vendidos";
            this.Load += new System.EventHandler(this.FrmTopProductos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalTopProductos;
    }
}