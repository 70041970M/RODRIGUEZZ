namespace Rodriguez.Vista
{
    partial class V_MantenimientoBuscarProductoVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgbListaProducto = new System.Windows.Forms.DataGridView();
            this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diseño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamaño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombrePro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiseño = new System.Windows.Forms.TextBox();
            this.txtPrecUnit = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgbListaProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // dgbListaProducto
            // 
            this.dgbListaProducto.AllowUserToAddRows = false;
            this.dgbListaProducto.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgbListaProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgbListaProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbListaProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item,
            this.idProducto,
            this.nombre,
            this.diseño,
            this.color,
            this.tamaño,
            this.material,
            this.precio,
            this.stock});
            this.dgbListaProducto.GridColor = System.Drawing.Color.Thistle;
            this.dgbListaProducto.Location = new System.Drawing.Point(33, 133);
            this.dgbListaProducto.Name = "dgbListaProducto";
            this.dgbListaProducto.ReadOnly = true;
            this.dgbListaProducto.RowHeadersVisible = false;
            this.dgbListaProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgbListaProducto.Size = new System.Drawing.Size(845, 195);
            this.dgbListaProducto.TabIndex = 39;
            this.dgbListaProducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbListaProducto_CellClick);
            this.dgbListaProducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbListaProducto_CellContentClick);
            // 
            // item
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item.DefaultCellStyle = dataGridViewCellStyle2;
            this.item.FillWeight = 60.91367F;
            this.item.HeaderText = "#";
            this.item.Name = "item";
            this.item.ReadOnly = true;
            this.item.Width = 35;
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
            this.nombre.FillWeight = 65.52537F;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 200;
            // 
            // diseño
            // 
            this.diseño.FillWeight = 118.3902F;
            this.diseño.HeaderText = "Diseño";
            this.diseño.Name = "diseño";
            this.diseño.ReadOnly = true;
            // 
            // color
            // 
            this.color.HeaderText = "Color";
            this.color.Name = "color";
            this.color.ReadOnly = true;
            // 
            // tamaño
            // 
            this.tamaño.HeaderText = "Tamaño";
            this.tamaño.Name = "tamaño";
            this.tamaño.ReadOnly = true;
            // 
            // material
            // 
            this.material.FillWeight = 118.3902F;
            this.material.HeaderText = "Material";
            this.material.Name = "material";
            this.material.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.FillWeight = 118.3902F;
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // stock
            // 
            this.stock.FillWeight = 118.3902F;
            this.stock.HeaderText = "Stock";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            // 
            // txtNombrePro
            // 
            this.txtNombrePro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombrePro.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombrePro.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtNombrePro.Location = new System.Drawing.Point(232, 35);
            this.txtNombrePro.MaxLength = 11;
            this.txtNombrePro.Name = "txtNombrePro";
            this.txtNombrePro.Size = new System.Drawing.Size(423, 26);
            this.txtNombrePro.TabIndex = 38;
            this.txtNombrePro.TextChanged += new System.EventHandler(this.txtNombrePro_TextChanged);
            this.txtNombrePro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNombrePro_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(57, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 18);
            this.label3.TabIndex = 37;
            this.label3.Text = "Buscar por Nombre";
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdProducto.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProducto.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtIdProducto.Location = new System.Drawing.Point(2, 2);
            this.txtIdProducto.MaxLength = 11;
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(10, 26);
            this.txtIdProducto.TabIndex = 58;
            this.txtIdProducto.Visible = false;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.nudCantidad.Location = new System.Drawing.Point(705, 88);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(144, 26);
            this.nudCantidad.TabIndex = 57;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.ValueChanged += new System.EventHandler(this.nudCantidad_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(602, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 18);
            this.label4.TabIndex = 55;
            this.label4.Text = "Cantidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(70, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 18);
            this.label1.TabIndex = 53;
            this.label1.Text = "Precio Unitario";
            // 
            // txtDiseño
            // 
            this.txtDiseño.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiseño.Enabled = false;
            this.txtDiseño.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiseño.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtDiseño.Location = new System.Drawing.Point(2, 37);
            this.txtDiseño.MaxLength = 11;
            this.txtDiseño.Name = "txtDiseño";
            this.txtDiseño.Size = new System.Drawing.Size(13, 26);
            this.txtDiseño.TabIndex = 52;
            this.txtDiseño.Visible = false;
            // 
            // txtPrecUnit
            // 
            this.txtPrecUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecUnit.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecUnit.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtPrecUnit.Location = new System.Drawing.Point(210, 82);
            this.txtPrecUnit.MaxLength = 11;
            this.txtPrecUnit.Name = "txtPrecUnit";
            this.txtPrecUnit.Size = new System.Drawing.Size(155, 26);
            this.txtPrecUnit.TabIndex = 51;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.AliceBlue;
            this.btnAgregar.ForeColor = System.Drawing.Color.DarkRed;
            this.btnAgregar.Location = new System.Drawing.Point(705, 32);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(114, 34);
            this.btnAgregar.TabIndex = 50;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(393, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 60;
            this.label2.Text = "Stock";
            // 
            // txtStock
            // 
            this.txtStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStock.Enabled = false;
            this.txtStock.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtStock.Location = new System.Drawing.Point(470, 82);
            this.txtStock.MaxLength = 11;
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(70, 26);
            this.txtStock.TabIndex = 59;
            // 
            // FrmMantenimientoBuscarProductoVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(964, 395);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtIdProducto);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDiseño);
            this.Controls.Add(this.txtPrecUnit);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgbListaProducto);
            this.Controls.Add(this.txtNombrePro);
            this.Controls.Add(this.label3);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FrmMantenimientoBuscarProductoVenta";
            this.Text = "Buscar Producto Venta";
            this.Load += new System.EventHandler(this.FrmMantenimientoBuscarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgbListaProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgbListaProducto;
        private System.Windows.Forms.TextBox txtNombrePro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiseño;
        private System.Windows.Forms.TextBox txtPrecUnit;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn item;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn diseño;
        private System.Windows.Forms.DataGridViewTextBoxColumn color;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamaño;
        private System.Windows.Forms.DataGridViewTextBoxColumn material;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
    }
}