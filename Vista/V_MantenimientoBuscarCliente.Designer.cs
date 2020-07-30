namespace Rodriguez.Vista
{
    partial class V_MantenimientoBuscarCliente
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
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgbListaCliente = new System.Windows.Forms.DataGridView();
            this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbEmpresa = new System.Windows.Forms.RadioButton();
            this.rbCliente = new System.Windows.Forms.RadioButton();
            this.txtRUC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListaRuc = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonsocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdClienteRUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgbListaCliente)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaRuc)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDNI
            // 
            this.txtDNI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDNI.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtDNI.Location = new System.Drawing.Point(251, 60);
            this.txtDNI.MaxLength = 8;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(358, 26);
            this.txtDNI.TabIndex = 0;
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            this.txtDNI.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDNI_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(191, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 18);
            this.label3.TabIndex = 34;
            this.label3.Text = "DNI";
            // 
            // dgbListaCliente
            // 
            this.dgbListaCliente.AllowUserToAddRows = false;
            this.dgbListaCliente.AllowUserToDeleteRows = false;
            this.dgbListaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbListaCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item,
            this.nombre,
            this.apellido,
            this.dni,
            this.IdCliente});
            this.dgbListaCliente.GridColor = System.Drawing.Color.Thistle;
            this.dgbListaCliente.Location = new System.Drawing.Point(49, 141);
            this.dgbListaCliente.Name = "dgbListaCliente";
            this.dgbListaCliente.ReadOnly = true;
            this.dgbListaCliente.Size = new System.Drawing.Size(550, 272);
            this.dgbListaCliente.TabIndex = 1;
            this.dgbListaCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbListaCliente_CellClick);
            this.dgbListaCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgbListaCliente_KeyDown);
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
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // dni
            // 
            this.dni.HeaderText = "DNI";
            this.dni.Name = "dni";
            this.dni.ReadOnly = true;
            // 
            // IdCliente
            // 
            this.IdCliente.HeaderText = "IdCliente";
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.ReadOnly = true;
            this.IdCliente.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbEmpresa);
            this.groupBox2.Controls.Add(this.rbCliente);
            this.groupBox2.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox2.Location = new System.Drawing.Point(26, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(151, 78);
            this.groupBox2.TabIndex = 106;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo";
            // 
            // rbEmpresa
            // 
            this.rbEmpresa.AutoSize = true;
            this.rbEmpresa.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEmpresa.ForeColor = System.Drawing.Color.LightGray;
            this.rbEmpresa.Location = new System.Drawing.Point(16, 45);
            this.rbEmpresa.Name = "rbEmpresa";
            this.rbEmpresa.Size = new System.Drawing.Size(81, 20);
            this.rbEmpresa.TabIndex = 104;
            this.rbEmpresa.Text = "Empresa";
            this.rbEmpresa.UseVisualStyleBackColor = true;
            this.rbEmpresa.CheckedChanged += new System.EventHandler(this.rbEmpresa_CheckedChanged);
            // 
            // rbCliente
            // 
            this.rbCliente.AutoSize = true;
            this.rbCliente.Checked = true;
            this.rbCliente.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCliente.ForeColor = System.Drawing.Color.LightGray;
            this.rbCliente.Location = new System.Drawing.Point(16, 19);
            this.rbCliente.Name = "rbCliente";
            this.rbCliente.Size = new System.Drawing.Size(123, 20);
            this.rbCliente.TabIndex = 103;
            this.rbCliente.TabStop = true;
            this.rbCliente.Text = "Cliente Natural";
            this.rbCliente.UseVisualStyleBackColor = true;
            this.rbCliente.CheckedChanged += new System.EventHandler(this.rbCliente_CheckedChanged);
            // 
            // txtRUC
            // 
            this.txtRUC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRUC.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRUC.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtRUC.Location = new System.Drawing.Point(251, 53);
            this.txtRUC.MaxLength = 11;
            this.txtRUC.Name = "txtRUC";
            this.txtRUC.Size = new System.Drawing.Size(358, 26);
            this.txtRUC.TabIndex = 107;
            this.txtRUC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRUC_KeyPress);
            this.txtRUC.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtRUC_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(191, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 108;
            this.label1.Text = "RUC";
            // 
            // dgvListaRuc
            // 
            this.dgvListaRuc.AllowUserToAddRows = false;
            this.dgvListaRuc.AllowUserToDeleteRows = false;
            this.dgvListaRuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaRuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.ruc,
            this.razonsocial,
            this.IdClienteRUC});
            this.dgvListaRuc.GridColor = System.Drawing.Color.Thistle;
            this.dgvListaRuc.Location = new System.Drawing.Point(49, 141);
            this.dgvListaRuc.Name = "dgvListaRuc";
            this.dgvListaRuc.ReadOnly = true;
            this.dgvListaRuc.Size = new System.Drawing.Size(550, 272);
            this.dgvListaRuc.TabIndex = 109;
            this.dgvListaRuc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaRuc_CellClick);
            this.dgvListaRuc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaRuc_CellContentClick);
            this.dgvListaRuc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvListaRuc_KeyDown);
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn1.HeaderText = "#";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ruc
            // 
            this.ruc.HeaderText = "RUC";
            this.ruc.Name = "ruc";
            this.ruc.ReadOnly = true;
            // 
            // razonsocial
            // 
            this.razonsocial.HeaderText = "Razon Social";
            this.razonsocial.Name = "razonsocial";
            this.razonsocial.ReadOnly = true;
            this.razonsocial.Width = 300;
            // 
            // IdClienteRUC
            // 
            this.IdClienteRUC.HeaderText = "IdCiente";
            this.IdClienteRUC.Name = "IdClienteRUC";
            this.IdClienteRUC.ReadOnly = true;
            this.IdClienteRUC.Visible = false;
            // 
            // FrmMantenimientoBuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(643, 458);
            this.Controls.Add(this.dgvListaRuc);
            this.Controls.Add(this.txtRUC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgbListaCliente);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.label3);
            this.Name = "FrmMantenimientoBuscarCliente";
            this.Text = " Buscar Cliente";
            this.Load += new System.EventHandler(this.FrmMantenimientoBuscarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgbListaCliente)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaRuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgbListaCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn item;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbEmpresa;
        private System.Windows.Forms.TextBox txtRUC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListaRuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruc;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonsocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdClienteRUC;
        public System.Windows.Forms.RadioButton rbCliente;
    }
}