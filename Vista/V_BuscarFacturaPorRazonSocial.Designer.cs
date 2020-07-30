namespace Rodriguez.Vista
{
    partial class V_BuscarFacturaPorRazonSocial
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtIdVenta = new System.Windows.Forms.TextBox();
            this.bnBuscar = new System.Windows.Forms.Button();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.dgbListaCliente = new System.Windows.Forms.DataGridView();
            this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idventa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgbListaCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdVenta
            // 
            this.txtIdVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdVenta.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdVenta.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtIdVenta.Location = new System.Drawing.Point(396, 352);
            this.txtIdVenta.MaxLength = 1000000;
            this.txtIdVenta.Name = "txtIdVenta";
            this.txtIdVenta.Size = new System.Drawing.Size(66, 26);
            this.txtIdVenta.TabIndex = 121;
            this.txtIdVenta.Text = "0";
            this.txtIdVenta.Visible = false;
            // 
            // bnBuscar
            // 
            this.bnBuscar.BackColor = System.Drawing.Color.Thistle;
            this.bnBuscar.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.bnBuscar.Location = new System.Drawing.Point(519, 38);
            this.bnBuscar.Name = "bnBuscar";
            this.bnBuscar.Size = new System.Drawing.Size(103, 48);
            this.bnBuscar.TabIndex = 120;
            this.bnBuscar.Text = "BUSCAR";
            this.bnBuscar.UseVisualStyleBackColor = false;
            this.bnBuscar.Click += new System.EventHandler(this.bnBuscar_Click);
            // 
            // btnimprimir
            // 
            this.btnimprimir.BackColor = System.Drawing.Color.Thistle;
            this.btnimprimir.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btnimprimir.Location = new System.Drawing.Point(507, 342);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(102, 45);
            this.btnimprimir.TabIndex = 119;
            this.btnimprimir.Text = "IMPRIMIR";
            this.btnimprimir.UseVisualStyleBackColor = false;
            this.btnimprimir.Click += new System.EventHandler(this.btnimprimir_Click);
            // 
            // dgbListaCliente
            // 
            this.dgbListaCliente.AllowUserToAddRows = false;
            this.dgbListaCliente.AllowUserToDeleteRows = false;
            this.dgbListaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbListaCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item,
            this.comprobante,
            this.fecha,
            this.idventa});
            this.dgbListaCliente.GridColor = System.Drawing.Color.Thistle;
            this.dgbListaCliente.Location = new System.Drawing.Point(105, 103);
            this.dgbListaCliente.Name = "dgbListaCliente";
            this.dgbListaCliente.ReadOnly = true;
            this.dgbListaCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgbListaCliente.Size = new System.Drawing.Size(480, 210);
            this.dgbListaCliente.TabIndex = 117;
            this.dgbListaCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbListaCliente_CellClick);
            // 
            // item
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item.DefaultCellStyle = dataGridViewCellStyle6;
            this.item.Frozen = true;
            this.item.HeaderText = "#";
            this.item.Name = "item";
            this.item.ReadOnly = true;
            this.item.Width = 90;
            // 
            // comprobante
            // 
            this.comprobante.Frozen = true;
            this.comprobante.HeaderText = "Comprobante";
            this.comprobante.Name = "comprobante";
            this.comprobante.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.Frozen = true;
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 75;
            // 
            // idventa
            // 
            this.idventa.Frozen = true;
            this.idventa.HeaderText = "Id Venta";
            this.idventa.Name = "idventa";
            this.idventa.ReadOnly = true;
            this.idventa.Visible = false;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRazonSocial.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazonSocial.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtRazonSocial.Location = new System.Drawing.Point(221, 50);
            this.txtRazonSocial.MaxLength = 1000000;
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(276, 26);
            this.txtRazonSocial.TabIndex = 116;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(102, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 18);
            this.label3.TabIndex = 118;
            this.label3.Text = "Razon Social";
            // 
            // FrmBuscarFacturaPorRazonSocial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(794, 440);
            this.Controls.Add(this.txtIdVenta);
            this.Controls.Add(this.bnBuscar);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.dgbListaCliente);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.label3);
            this.Name = "FrmBuscarFacturaPorRazonSocial";
            this.Text = "Buscar Factura";
            ((System.ComponentModel.ISupportInitialize)(this.dgbListaCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdVenta;
        private System.Windows.Forms.Button bnBuscar;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.DataGridView dgbListaCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn item;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn idventa;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label label3;
    }
}