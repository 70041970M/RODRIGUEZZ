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
    public partial class V_MantenimientoBuscarEmpleado : Form
    {
        public Int16 id = -1;


        public V_MantenimientoBuscarEmpleado()
        {
            InitializeComponent();
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtDNI_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                // detectar si ha presionado la tecla enter
                if (e.KeyCode == Keys.Return)
                {

                    dgbListaEmpleado.Rows.Clear();

                    C_Empleado C_empleado = new C_Empleado();
                    List<Empleado> empleados = new List<Empleado>();

                    string dni = txtDNI.Text;

                    empleados = C_empleado.C_buscarPorDNI_empleado(dni);

                    foreach (Empleado empleado  in empleados)
                    {

                        dgbListaEmpleado.Rows.Add(dgbListaEmpleado.Rows.Count
                                          , empleado.Nombre
                                          , empleado.Apellido
                                          , empleado.Dni
                                          , empleado.Cargo
                                          , empleado.Idempleado);



                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "aviso");
            }
        }

        private void dgbListaEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.id = Convert.ToInt16(dgbListaEmpleado.Rows[e.RowIndex].Cells["IdEmpleado"].Value.ToString());
              this.Close();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
            
        }

        private void FrmMantenimientoBuscarEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgbListaEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtDNI_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsNumber((e.KeyChar)) && (Convert.ToInt32((e.KeyChar)) != 8)))
            {
                e.Handled = true;
            }
        }
    }
}
