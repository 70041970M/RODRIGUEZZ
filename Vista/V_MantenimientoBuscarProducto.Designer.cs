namespace Rodriguez.Vista
{
    partial class V_MantenimientoBuscarProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgbListaProducto = new System.Windows.Forms.DataGridView();
            this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diseño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombrePro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgbListaProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgbListaProducto
            // 
            this.dgbListaProducto.AllowUserToAddRows = false;
            this.dgbListaProducto.AllowUserToDeleteRows = false;
            this.dgbListaProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbListaProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item,
            this.idProducto,
            this.nombre,
            this.diseño,
            this.material,
            this.precio,
            this.categoria,
            this.stock});
            this.dgbListaProducto.GridColor = System.Drawing.Color.Thistle;
            this.dgbListaProducto.Location = new System.Drawing.Point(34, 70);
            this.dgbListaProducto.Name = "dgbListaProducto";
            this.dgbListaProducto.ReadOnly = true;
            this.dgbListaProducto.Size = new System.Drawing.Size(749, 266);
            this.dgbListaProducto.TabIndex = 40;
            this.dgbListaProducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbListaProducto_CellClick);
            this.dgbListaProducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbListaProducto_CellContentClick);
            // 
            // item
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item.DefaultCellStyle = dataGridViewCellStyle1;
            this.item.HeaderText = "#";
            this.item.Name = "item";
            this.item.ReadOnly = true;
            // 
            // idProducto
            // 
            this.idProducto.HeaderText = "ID Producto";
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            this.idProducto.Visible = false;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // diseño
            // 
            this.diseño.HeaderText = "Diseño";
            this.diseño.Name = "diseño";
            this.diseño.ReadOnly = true;
            // 
            // material
            // 
            this.material.HeaderText = "Material";
            this.material.Name = "material";
            this.material.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // categoria
            // 
            this.categoria.HeaderText = "Categoria";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            // 
            // stock
            // 
            this.stock.HeaderText = "Stock";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            // 
            // txtNombrePro
            // 
            this.txtNombrePro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombrePro.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombrePro.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtNombrePro.Location = new System.Drawing.Point(215, 12);
            this.txtNombrePro.MaxLength = 11;
            this.txtNombrePro.Name = "txtNombrePro";
            this.txtNombrePro.Size = new System.Drawing.Size(359, 26);
            this.txtNombrePro.TabIndex = 42;
            this.txtNombrePro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNombrePro_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(122, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 41;
            this.label3.Text = "Buscar";
            // 
            // FrmMantenimientoBuscarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(807, 375);
            this.Controls.Add(this.txtNombrePro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgbListaProducto);
            this.Name = "FrmMantenimientoBuscarProducto";
            this.Text = "Buscar Producto";
            this.Load += new System.EventHandler(this.FrmMantenimientoBuscarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgbListaProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgbListaProducto;
        private System.Windows.Forms.TextBox txtNombrePro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn item;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn diseño;
        private System.Windows.Forms.DataGridViewTextBoxColumn material;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
    }
}