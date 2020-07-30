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
    public partial class V_CambiarClave : Form
    {
        public V_CambiarClave()
        {
            InitializeComponent();
        }

        private void frmCambiarClave_Load(object sender, EventArgs e)
        {
            txtidEmpleado.Text = EmpleadoLogueado.idempleado.ToString();
            txtNombre.Text = EmpleadoLogueado.nombre;
            txtDni.Text = EmpleadoLogueado.dni;
            txtCargo.Text = EmpleadoLogueado.cargo;
        }

        private void btncambiarclave_Click(object sender, EventArgs e)
        {

            try
            {

                string claveActual = txtClaveActual.Text;
                string claveNueva1 = txtClaveNueva.Text;
                string claveNueva2 = txtRepetirClaveNueva.Text;


                if (string.IsNullOrEmpty(claveActual))
                {
                    MessageBox.Show("La clave actual no puede estar vacia");
                    return;
                }

                if (string.IsNullOrEmpty(claveNueva1))
                {
                    MessageBox.Show("La clave nueva no puede estar vacia");
                    return;
                }

                if (string.IsNullOrEmpty(claveNueva2))
                {
                    MessageBox.Show("La clave nueva repetida no puede estar vacia");
                    return;
                }


                if (claveNueva1.CompareTo(claveNueva2) != 0)
                {

                    MessageBox.Show("Las claves nuevas no coinciden");
                    return;
                }

                C_Empleado C_empleado = new C_Empleado();
                C_empleado.C_cambiarClave_empleado(claveActual, claveNueva1);
                MessageBox.Show("La clave ha sido cambiada");



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }






        }
    }
}
