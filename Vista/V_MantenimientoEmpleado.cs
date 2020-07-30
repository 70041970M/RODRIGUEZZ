using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Data.SqlClient;
using Rodriguez.Controlador;
using Rodriguez.Utilities;
using Rodriguez.Entitites;
using Rodriguez.Connection;

namespace Rodriguez.Vista
{
    public partial class V_MantenimientoEmpleado : Form
    {
        public V_MantenimientoEmpleado()
        {
            InitializeComponent();
        }

        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtDNIEmp.Text == "")
            {
                MessageBox.Show("El campo DNI no debe estar vacio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            try
            {
                Int16 id;
                Int16.TryParse(txtIdEmp.Text, out id);

                //---creamos un objeto cliente
                Empleado empleado = new Empleado();

                //--- llenar de datos al objeto cliente
              
                if (id == 0)
                {
                 
                           
                empleado.Dni = txtDNIEmp.Text;
                empleado.Nombre= txtNombreEmp.Text;
                empleado.Apellido = txtApellidosEmp.Text;
                empleado.Cargo = cmbCargo.Text;
                empleado.Direccion = txtDireccionEmp.Text;
                empleado.Telefono = txtTelefonoEmp.Text;
                empleado.Contraseña = txtContraseña.Text;
                empleado.Fechanacimiento = txtFechaNac.Value;
                empleado.Fechaentrada = txtFechaEntrada.Value;



                C_Empleado C_emprealdo = new C_Empleado();

              
                    //--insertar----

                    Int32 resp = C_emprealdo.C_insertar_empleado(empleado);
                    txtIdEmp.Text = empleado.Idempleado.ToString();
                    MessageBox.Show("EMPLEADO REGISTRADO SATISFACTORIAMENTE", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            
            
                else
                {
                    empleado.Dni = txtDNIEmp.Text;
                    empleado.Nombre = txtNombreEmp.Text;
                    empleado.Apellido = txtApellidosEmp.Text;
                    empleado.Cargo = cmbCargo.Text.ToUpper();
                    empleado.Direccion = txtDireccionEmp.Text;
                    empleado.Telefono = txtTelefonoEmp.Text;
                    //empleado.Contraseña = txtContraseña.Text;
                    empleado.Fechanacimiento = txtFechaNac.Value;
                    empleado.Fechaentrada = txtFechaEntrada.Value;



                    C_Empleado C_empleado = new C_Empleado();

                    //----actualizado

                    empleado.Idempleado = id;
                    Int32 resp = C_empleado.C_actualizar_empleado(empleado);
                    MessageBox.Show("EMPLEADO ACTUALIZADO SATISFACTORIAMENTE", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                 

            }

            catch (Exception ex)
            {

                //MessageBox.Show("EL DNI YA SE ENCUENTRA REGISTRADO, POR FAVOR INGRESE DNI CORRECTO", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               MessageBox.Show(ex.Message /*+ "-" + ex.StackTrace.ToString()*/);

            }

      


        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                Int16 id;
                Int16.TryParse(txtIdEmp.Text, out id);


                if (id > 0)
                {

                    DialogResult dialog;
                    dialog = MessageBox.Show("¿Esta seguro de eliminar este registro?"
                                            , "Confirmacion"
                                            , MessageBoxButtons.YesNo
                                            , MessageBoxIcon.Question);


                    if (dialog == DialogResult.Yes)
                    {

                        C_Empleado C_empleado = new C_Empleado();
                        C_empleado.C_eliminar_empleado(id);
                        MessageBox.Show("EMPLEADO ELIMINADO SATISFACTORIAMENTE", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.txtIdEmp.Clear();
                        this.txtDNIEmp.Clear();
                        this.txtNombreEmp.Clear();
                        this.txtApellidosEmp.Clear();
                        this.cmbCargo.SelectedIndex = 1;
                        this.txtDireccionEmp.Clear();
                        this.txtTelefonoEmp.Clear();
                        this.txtContraseña.Clear();
                        this.cmbCargo.SelectedIndex = 1;
                        this.txtDNIEmp.Enabled = true;

                    }

                }
         }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso");

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {


            try
            {

                V_MantenimientoBuscarEmpleado form;
                form = new V_MantenimientoBuscarEmpleado();

                form.ShowDialog(this);


                if (form.id > 0)
                {

                    C_Empleado C_empleado = new C_Empleado();
                    Empleado empleado = C_empleado.C_buscarPorId_empleado(form.id);

                    this.txtDireccionEmp.Enabled = true;
                    this.txtTelefonoEmp.Enabled = true;
                    this.txtFechaEntrada.Enabled = true;
                    this.txtFechaNac.Enabled = true;

                    txtIdEmp.Text = empleado.Idempleado.ToString();
                    txtDNIEmp.Text = empleado.Dni.ToString();
                    txtNombreEmp.Text = empleado.Nombre.ToString();
                    txtApellidosEmp.Text = empleado.Apellido.ToString();
                    cmbCargo.Text = empleado.Cargo.ToString();
                    txtDireccionEmp.Text = empleado.Direccion.ToString();
                    txtTelefonoEmp.Text = empleado.Telefono.ToString();
                   // txtContraseña.Text = empleado.Contraseña.ToString();
                    txtFechaNac.Text = empleado.Fechanacimiento.ToString();
                    txtFechaEntrada.Text = empleado.Fechaentrada.ToString();
                    this.txtContraseña.Hide();
                    this.label11.Hide();
                    txtDNIEmp.Enabled = false;
                    
                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "aviso");

            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
                        DialogResult result = MessageBox.Show("¿Desea registrar nuevo empleado?", "Nuevo Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.txtDNIEmp.Enabled = true;
                this.txtIdEmp.Clear();
                this.txtDNIEmp.Clear();
                this.txtNombreEmp.Clear();
                this.txtApellidosEmp.Clear();
                this.cmbCargo.SelectedIndex = 1;
;                this.txtDireccionEmp.Clear();
                this.txtTelefonoEmp.Clear();
                this.txtContraseña.Clear();
                this.txtContraseña.Visible = true;
                this.label11.Visible = true;
              
                this.txtDireccionEmp.Enabled = false;
                this.txtTelefonoEmp.Enabled = false;
                this.txtFechaNac.Enabled = false;

                if (!string.IsNullOrEmpty(txtApellidosEmp.Text))
                {

                  
                    this.txtDireccionEmp.Enabled = true;
                    this.txtTelefonoEmp.Enabled = true;
                    this.txtFechaNac.Enabled = true;
                }

                
            }
            else result = DialogResult.No;
        
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmMantenimientoEmpleado_Load(object sender, EventArgs e)
        {
            this.cmbCargo.SelectedIndex = 1;
        }

        private void txtDNIEmp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsNumber((e.KeyChar)) && (Convert.ToInt32((e.KeyChar)) != 8)))
            {
                e.Handled = true;
            }
        }

  

        private void txtDireccionEmp_KeyPress(object sender, KeyPressEventArgs e)
        {
                 
        }

        private void txtApellidosEmp_Leave(object sender, EventArgs e)
        {

            txtContraseña.Text = txtApellidosEmp.Text.Substring(0, 1).ToUpper() + txtApellidosEmp.Text.Substring(txtApellidosEmp.TextLength - 1, 1).ToUpper() + txtDNIEmp.Text.Substring(0, 1).ToUpper() + txtDNIEmp.Text.Substring(5, 1).ToUpper() + txtNombreEmp.Text.Substring(txtNombreEmp.TextLength - 2, 2).ToUpper();
            
            if(!string.IsNullOrEmpty(txtApellidosEmp.Text)){

               
                this.txtDireccionEmp.Enabled = true;
                this.txtTelefonoEmp.Enabled = true;
                this.txtFechaNac.Enabled = true;
                }

               

          

             

        }

    

 

        ///////////////////////////////////////////////////////////////////////////////////////////////////


    }
}
