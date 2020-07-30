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
using System.Data.SqlClient;
using Rodriguez.Utilities;


using Rodriguez.Connection;


namespace Rodriguez.Vista
{
    public partial class V_BuscarListarCliente : Form
    {
        public V_BuscarListarCliente()
        {
            InitializeComponent();
        }
       
        
        private void btnimprimir_Click(object sender, EventArgs e)
        {
            if (this.rbnempresa.Checked == true)
            {
                V_ReporteClientesEmpresa form = new V_ReporteClientesEmpresa();
                form.fechaIni = Convert.ToDateTime(dtpini.Value);
                form.fechaFin = Convert.ToDateTime(dtpfin.Value);
                form.Show();
            }
            else
            {
                V_ReporteClienteNatural form = new V_ReporteClienteNatural();
                form.fechaIni = Convert.ToDateTime(dtpini.Value);
                form.fechaFin = Convert.ToDateTime(dtpfin.Value);
                form.Show();
            }
        }

        private void bnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                // detectar si ha presionado la tecla enter
                if (this.rbnnatural.Checked == true)
                {
                    dgvListaNatural.Rows.Clear();
                    dgvEmpresa.Rows.Clear();
               

                    C_Cliente C_cliente = new C_Cliente();
                    List<Cliente> clientes = new List<Cliente>();

                    DateTime fechaIni =  dtpini.Value;
                    DateTime fechaFin = dtpfin.Value;
                    

                    clientes = C_cliente.C_Buscar_clienteNatural(fechaIni, fechaFin);

                    foreach (Cliente cliente in clientes)
                    {

                        dgvListaNatural.Rows.Add(dgvListaNatural.Rows.Count
                                          , cliente.Dni
                                          , cliente.Nombre
                                          , cliente.Apellido
                                          , cliente.Direccion
                                          , cliente.Telefono
                                          , cliente.Idcliente);


                    }
                }
                else if (this.rbnempresa.Checked == true)
                
                {

                    dgvEmpresa.Rows.Clear();
                    dgvListaNatural.Rows.Clear();
                 


                    C_Cliente C_cliente = new C_Cliente();
                    List<Cliente> clientes = new List<Cliente>();

                    DateTime fechaIni =  dtpini.Value;
                    DateTime fechaFin = dtpfin.Value;
                    

                    clientes = C_cliente.C_Buscar_clienteEmpresa(fechaIni, fechaFin);

                    foreach (Cliente cliente in clientes)
                    {

                        dgvEmpresa.Rows.Add(dgvEmpresa.Rows.Count
                                          , cliente.Ruc
                                          , cliente.Razonsocial
                                          , cliente.Direccion
                                          , cliente.Correo
                                          , cliente.Telefono
                                          , cliente.Idcliente);


                    }
                
                
                }
                btnimprimir.Enabled = true;

              

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "aviso");
            }

        }


       

        private void FrmBuscar_Cliente_Natural_Load(object sender, EventArgs e)
        {
            btnimprimir.Enabled = false;
            dgvListaNatural.Visible = true;
            dgvEmpresa.Visible = false;
            //dtpini.Value = DateTime.Today - 1();
        }

        private void dgvListaNatural_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rbnempresa_CheckedChanged(object sender, EventArgs e)
        {
            btnimprimir.Enabled = false;
            dgvListaNatural.Visible = false;
            dgvEmpresa.Visible = true;
        }

        private void rbnnatural_CheckedChanged(object sender, EventArgs e)
        {
            btnimprimir.Enabled = false;
            dgvListaNatural.Visible = true;
            dgvEmpresa.Visible = false;
        }

        private void dtpini_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
