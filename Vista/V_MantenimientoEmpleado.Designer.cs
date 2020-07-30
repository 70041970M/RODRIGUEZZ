namespace Rodriguez.Vista
{
    partial class V_MantenimientoEmpleado
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtTelefonoEmp = new System.Windows.Forms.TextBox();
            this.txtDireccionEmp = new System.Windows.Forms.TextBox();
            this.txtApellidosEmp = new System.Windows.Forms.TextBox();
            this.txtNombreEmp = new System.Windows.Forms.TextBox();
            this.txtDNIEmp = new System.Windows.Forms.TextBox();
            this.txtIdEmp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFechaNac = new System.Windows.Forms.DateTimePicker();
            this.txtFechaEntrada = new System.Windows.Forms.DateTimePicker();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Location = new System.Drawing.Point(544, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 248);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.AliceBlue;
            this.btnBuscar.ForeColor = System.Drawing.Color.Navy;
            this.btnBuscar.Location = new System.Drawing.Point(28, 183);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(90, 35);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.AliceBlue;
            this.btnEliminar.ForeColor = System.Drawing.Color.Navy;
            this.btnEliminar.Location = new System.Drawing.Point(28, 131);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(90, 35);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.AliceBlue;
            this.btnNuevo.ForeColor = System.Drawing.Color.Navy;
            this.btnNuevo.Location = new System.Drawing.Point(28, 77);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(90, 35);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.AliceBlue;
            this.btnGuardar.ForeColor = System.Drawing.Color.Navy;
            this.btnGuardar.Location = new System.Drawing.Point(28, 28);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(90, 32);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtTelefonoEmp
            // 
            this.txtTelefonoEmp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtTelefonoEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefonoEmp.Enabled = false;
            this.txtTelefonoEmp.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoEmp.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtTelefonoEmp.Location = new System.Drawing.Point(136, 280);
            this.txtTelefonoEmp.MaxLength = 50;
            this.txtTelefonoEmp.Name = "txtTelefonoEmp";
            this.txtTelefonoEmp.Size = new System.Drawing.Size(168, 26);
            this.txtTelefonoEmp.TabIndex = 5;
            // 
            // txtDireccionEmp
            // 
            this.txtDireccionEmp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtDireccionEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccionEmp.Enabled = false;
            this.txtDireccionEmp.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionEmp.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtDireccionEmp.Location = new System.Drawing.Point(135, 227);
            this.txtDireccionEmp.MaxLength = 50;
            this.txtDireccionEmp.Name = "txtDireccionEmp";
            this.txtDireccionEmp.Size = new System.Drawing.Size(355, 26);
            this.txtDireccionEmp.TabIndex = 4;
            this.txtDireccionEmp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccionEmp_KeyPress);
            // 
            // txtApellidosEmp
            // 
            this.txtApellidosEmp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtApellidosEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellidosEmp.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidosEmp.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtApellidosEmp.Location = new System.Drawing.Point(135, 131);
            this.txtApellidosEmp.MaxLength = 100;
            this.txtApellidosEmp.Name = "txtApellidosEmp";
            this.txtApellidosEmp.Size = new System.Drawing.Size(355, 26);
            this.txtApellidosEmp.TabIndex = 2;
            this.txtApellidosEmp.Leave += new System.EventHandler(this.txtApellidosEmp_Leave);
            // 
            // txtNombreEmp
            // 
            this.txtNombreEmp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtNombreEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreEmp.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEmp.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtNombreEmp.Location = new System.Drawing.Point(135, 87);
            this.txtNombreEmp.MaxLength = 100000;
            this.txtNombreEmp.Name = "txtNombreEmp";
            this.txtNombreEmp.Size = new System.Drawing.Size(355, 26);
            this.txtNombreEmp.TabIndex = 1;
            // 
            // txtDNIEmp
            // 
            this.txtDNIEmp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtDNIEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDNIEmp.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNIEmp.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtDNIEmp.Location = new System.Drawing.Point(135, 42);
            this.txtDNIEmp.MaxLength = 8;
            this.txtDNIEmp.Name = "txtDNIEmp";
            this.txtDNIEmp.Size = new System.Drawing.Size(214, 26);
            this.txtDNIEmp.TabIndex = 0;
            this.txtDNIEmp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNIEmp_KeyPress);
            // 
            // txtIdEmp
            // 
            this.txtIdEmp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtIdEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdEmp.Enabled = false;
            this.txtIdEmp.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdEmp.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtIdEmp.Location = new System.Drawing.Point(708, 36);
            this.txtIdEmp.Name = "txtIdEmp";
            this.txtIdEmp.ReadOnly = true;
            this.txtIdEmp.Size = new System.Drawing.Size(16, 26);
            this.txtIdEmp.TabIndex = 49;
            this.txtIdEmp.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(47, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 18);
            this.label6.TabIndex = 47;
            this.label6.Text = "Teléfono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(41, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 46;
            this.label5.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(44, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 45;
            this.label4.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(40, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 44;
            this.label3.Text = "Nombres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(81, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 18);
            this.label2.TabIndex = 43;
            this.label2.Text = "DNI";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(56, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 18);
            this.label8.TabIndex = 57;
            this.label8.Text = "Cargo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(346, 338);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 18);
            this.label9.TabIndex = 60;
            this.label9.Text = "Fecha Registro";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Silver;
            this.label10.Location = new System.Drawing.Point(324, 290);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 18);
            this.label10.TabIndex = 59;
            this.label10.Text = "Fecha Nacimiento";
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContraseña.Enabled = false;
            this.txtContraseña.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtContraseña.Location = new System.Drawing.Point(136, 332);
            this.txtContraseña.MaxLength = 50;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(168, 26);
            this.txtContraseña.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Silver;
            this.label11.Location = new System.Drawing.Point(23, 334);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 18);
            this.label11.TabIndex = 63;
            this.label11.Text = "Contraseña";
            // 
            // txtFechaNac
            // 
            this.txtFechaNac.CalendarFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaNac.Location = new System.Drawing.Point(487, 287);
            this.txtFechaNac.MaxDate = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            this.txtFechaNac.Name = "txtFechaNac";
            this.txtFechaNac.Size = new System.Drawing.Size(200, 22);
            this.txtFechaNac.TabIndex = 6;
            this.txtFechaNac.Value = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            // 
            // txtFechaEntrada
            // 
            this.txtFechaEntrada.CalendarFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaEntrada.Enabled = false;
            this.txtFechaEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaEntrada.Location = new System.Drawing.Point(487, 336);
            this.txtFechaEntrada.Name = "txtFechaEntrada";
            this.txtFechaEntrada.Size = new System.Drawing.Size(200, 22);
            this.txtFechaEntrada.TabIndex = 9;
            // 
            // cmbCargo
            // 
            this.cmbCargo.BackColor = System.Drawing.SystemColors.Info;
            this.cmbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Items.AddRange(new object[] {
            "ADMINISTRADOR",
            "VENDEDOR"});
            this.cmbCargo.Location = new System.Drawing.Point(136, 176);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(213, 26);
            this.cmbCargo.TabIndex = 3;
            this.cmbCargo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FrmMantenimientoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(731, 402);
            this.Controls.Add(this.cmbCargo);
            this.Controls.Add(this.txtFechaEntrada);
            this.Controls.Add(this.txtFechaNac);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTelefonoEmp);
            this.Controls.Add(this.txtDireccionEmp);
            this.Controls.Add(this.txtApellidosEmp);
            this.Controls.Add(this.txtNombreEmp);
            this.Controls.Add(this.txtDNIEmp);
            this.Controls.Add(this.txtIdEmp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.Name = "FrmMantenimientoEmpleado";
            this.Text = "Mantenimiento Empleado";
            this.Load += new System.EventHandler(this.FrmMantenimientoEmpleado_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtTelefonoEmp;
        private System.Windows.Forms.TextBox txtDireccionEmp;
        private System.Windows.Forms.TextBox txtApellidosEmp;
        private System.Windows.Forms.TextBox txtNombreEmp;
        private System.Windows.Forms.TextBox txtDNIEmp;
        private System.Windows.Forms.TextBox txtIdEmp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker txtFechaNac;
        private System.Windows.Forms.DateTimePicker txtFechaEntrada;
        private System.Windows.Forms.ComboBox cmbCargo;
    }
}