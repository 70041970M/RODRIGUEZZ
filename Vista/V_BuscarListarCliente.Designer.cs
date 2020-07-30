namespace Rodriguez.Vista
{
    partial class V_BuscarListarCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rbnnatural = new System.Windows.Forms.RadioButton();
            this.rbnempresa = new System.Windows.Forms.RadioButton();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.dtpini = new System.Windows.Forms.DateTimePicker();
            this.dtpfin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvListaNatural = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdClienteRUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.bnBuscar = new System.Windows.Forms.Button();
            this.dgvEmpresa = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonsocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaNatural)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresa)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbnnatural
            // 
            this.rbnnatural.AutoSize = true;
            this.rbnnatural.Checked = true;
            this.rbnnatural.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.rbnnatural.Location = new System.Drawing.Point(34, 28);
            this.rbnnatural.Name = "rbnnatural";
            this.rbnnatural.Size = new System.Drawing.Size(122, 20);
            this.rbnnatural.TabIndex = 0;
            this.rbnnatural.TabStop = true;
            this.rbnnatural.Text = "Cliente natural";
            this.rbnnatural.UseVisualStyleBackColor = true;
            this.rbnnatural.CheckedChanged += new System.EventHandler(this.rbnnatural_CheckedChanged);
            // 
            // rbnempresa
            // 
            this.rbnempresa.AutoSize = true;
            this.rbnempresa.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.rbnempresa.Location = new System.Drawing.Point(34, 53);
            this.rbnempresa.Name = "rbnempresa";
            this.rbnempresa.Size = new System.Drawing.Size(81, 20);
            this.rbnempresa.TabIndex = 1;
            this.rbnempresa.TabStop = true;
            this.rbnempresa.Text = "Empresa";
            this.rbnempresa.UseVisualStyleBackColor = true;
            this.rbnempresa.CheckedChanged += new System.EventHandler(this.rbnempresa_CheckedChanged);
            // 
            // dtpini
            // 
            this.dtpini.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.dtpini.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpini.Location = new System.Drawing.Point(469, 49);
            this.dtpini.MaxDate = new System.DateTime(2017, 11, 23, 0, 0, 0, 0);
            this.dtpini.Name = "dtpini";
            this.dtpini.Size = new System.Drawing.Size(106, 23);
            this.dtpini.TabIndex = 2;
            this.dtpini.Value = new System.DateTime(2017, 11, 23, 0, 0, 0, 0);
            this.dtpini.ValueChanged += new System.EventHandler(this.dtpini_ValueChanged);
            // 
            // dtpfin
            // 
            this.dtpfin.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.dtpfin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfin.Location = new System.Drawing.Point(724, 47);
            this.dtpfin.MaxDate = new System.DateTime(2017, 11, 23, 0, 0, 0, 0);
            this.dtpfin.Name = "dtpfin";
            this.dtpfin.Size = new System.Drawing.Size(106, 23);
            this.dtpfin.TabIndex = 3;
            this.dtpfin.Value = new System.DateTime(2017, 11, 23, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(398, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Desde:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(655, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hasta:";
            // 
            // dgvListaNatural
            // 
            this.dgvListaNatural.AllowUserToAddRows = false;
            this.dgvListaNatural.AllowUserToDeleteRows = false;
            this.dgvListaNatural.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaNatural.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dni,
            this.nombres,
            this.apellido,
            this.direccion,
            this.telefono,
            this.IdClienteRUC});
            this.dgvListaNatural.GridColor = System.Drawing.Color.Thistle;
            this.dgvListaNatural.Location = new System.Drawing.Point(94, 113);
            this.dgvListaNatural.Name = "dgvListaNatural";
            this.dgvListaNatural.ReadOnly = true;
            this.dgvListaNatural.Size = new System.Drawing.Size(976, 218);
            this.dgvListaNatural.TabIndex = 110;
            this.dgvListaNatural.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaNatural_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn1.HeaderText = "#";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dni
            // 
            this.dni.HeaderText = "DNI";
            this.dni.Name = "dni";
            this.dni.ReadOnly = true;
            this.dni.Width = 130;
            // 
            // nombres
            // 
            this.nombres.HeaderText = "Nombre";
            this.nombres.Name = "nombres";
            this.nombres.ReadOnly = true;
            this.nombres.Width = 200;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            this.apellido.Width = 200;
            // 
            // direccion
            // 
            this.direccion.HeaderText = "Direccion";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            this.direccion.Width = 200;
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Width = 150;
            // 
            // IdClienteRUC
            // 
            this.IdClienteRUC.HeaderText = "IdCiente";
            this.IdClienteRUC.Name = "IdClienteRUC";
            this.IdClienteRUC.ReadOnly = true;
            this.IdClienteRUC.Visible = false;
            // 
            // btnimprimir
            // 
            this.btnimprimir.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.btnimprimir.Location = new System.Drawing.Point(916, 352);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(102, 45);
            this.btnimprimir.TabIndex = 111;
            this.btnimprimir.Text = "IMPRIMIR";
            this.btnimprimir.UseVisualStyleBackColor = true;
            this.btnimprimir.Click += new System.EventHandler(this.btnimprimir_Click);
            // 
            // bnBuscar
            // 
            this.bnBuscar.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.bnBuscar.Location = new System.Drawing.Point(902, 37);
            this.bnBuscar.Name = "bnBuscar";
            this.bnBuscar.Size = new System.Drawing.Size(103, 48);
            this.bnBuscar.TabIndex = 112;
            this.bnBuscar.Text = "BUSCAR";
            this.bnBuscar.UseVisualStyleBackColor = true;
            this.bnBuscar.Click += new System.EventHandler(this.bnBuscar_Click);
            // 
            // dgvEmpresa
            // 
            this.dgvEmpresa.AllowUserToAddRows = false;
            this.dgvEmpresa.AllowUserToDeleteRows = false;
            this.dgvEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpresa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.ruc,
            this.razonsocial,
            this.dataGridViewTextBoxColumn6,
            this.correo,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dgvEmpresa.GridColor = System.Drawing.Color.Thistle;
            this.dgvEmpresa.Location = new System.Drawing.Point(94, 113);
            this.dgvEmpresa.Name = "dgvEmpresa";
            this.dgvEmpresa.ReadOnly = true;
            this.dgvEmpresa.Size = new System.Drawing.Size(976, 218);
            this.dgvEmpresa.TabIndex = 113;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn2.HeaderText = "#";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 50;
            // 
            // ruc
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ruc.DefaultCellStyle = dataGridViewCellStyle3;
            this.ruc.HeaderText = "RUC";
            this.ruc.Name = "ruc";
            this.ruc.ReadOnly = true;
            this.ruc.Width = 130;
            // 
            // razonsocial
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.razonsocial.DefaultCellStyle = dataGridViewCellStyle4;
            this.razonsocial.HeaderText = "Razon Social";
            this.razonsocial.Name = "razonsocial";
            this.razonsocial.ReadOnly = true;
            this.razonsocial.Width = 200;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn6.HeaderText = "Direccion";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 200;
            // 
            // correo
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.correo.DefaultCellStyle = dataGridViewCellStyle6;
            this.correo.HeaderText = "Correo";
            this.correo.Name = "correo";
            this.correo.ReadOnly = true;
            this.correo.Width = 200;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn7.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn8.HeaderText = "IdCiente";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnempresa);
            this.groupBox1.Controls.Add(this.rbnnatural);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Location = new System.Drawing.Point(139, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 88);
            this.groupBox1.TabIndex = 114;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar por";
            // 
            // FrmBuscarListarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1145, 409);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvEmpresa);
            this.Controls.Add(this.bnBuscar);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.dgvListaNatural);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpfin);
            this.Controls.Add(this.dtpini);
            this.Name = "FrmBuscarListarCliente";
            this.Text = "Busqueda de Clientes por Fecha";
            this.Load += new System.EventHandler(this.FrmBuscar_Cliente_Natural_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaNatural)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbnnatural;
        private System.Windows.Forms.RadioButton rbnempresa;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.DateTimePicker dtpini;
        private System.Windows.Forms.DateTimePicker dtpfin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvListaNatural;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.Button bnBuscar;
        private System.Windows.Forms.DataGridView dgvEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdClienteRUC;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruc;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonsocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}