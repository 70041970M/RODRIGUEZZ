using Rodriguez.Controlador;
using Rodriguez.Entitites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rodriguez.Vista
{
    public partial class V_Login : Form
    {
        public V_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Empleado empleado = new Empleado();
                empleado.Dni = txtDNI.Text;
                empleado.Contraseña = txtClave.Text;
                C_Empleado C_empleado = new C_Empleado();
                bool resp = C_empleado.C_validar_mpleado(empleado);
                if (resp)
                {
                    EmpleadoLogueado.idempleado = empleado.Idempleado;
                    EmpleadoLogueado.nombre = empleado.Nombre;
                    EmpleadoLogueado.apellido = empleado.Apellido;
                    EmpleadoLogueado.direccion = empleado.Direccion;
                    EmpleadoLogueado.cargo = empleado.Cargo;
                    EmpleadoLogueado.telefono = empleado.Telefono;
                    EmpleadoLogueado.dni = empleado.Dni;
                    EmpleadoLogueado.fechanacimiento = empleado.Fechanacimiento;
                    EmpleadoLogueado.fechaentrada = empleado.Fechaentrada;
                    EmpleadoLogueado.contraseña = empleado.Contraseña;
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Acceso denegado", "Aviso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso");
            }








        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsNumber((e.KeyChar)) && (Convert.ToInt32((e.KeyChar)) != 8)))
            {
                e.Handled = true;
            }
        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
