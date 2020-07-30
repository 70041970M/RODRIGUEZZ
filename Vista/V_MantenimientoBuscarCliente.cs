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
using Rodriguez.Utilities;

namespace Rodriguez.Vista
{
   
    public partial class V_MantenimientoBuscarCliente : Form
    {
        public Int16 id = -1;

       

        public V_MantenimientoBuscarCliente()
        {
            InitializeComponent();
        }

        private void txtDNI_KeyUp(object sender, KeyEventArgs e)
        {
           try
            {
                // detectar si ha presionado la tecla enter
                if (e.KeyCode == Keys.Return)
                {

                    dgbListaCliente.Rows.Clear();

                    C_Cliente C_cliente = new C_Cliente();
                    List<Cliente> clientes = new List<Cliente>();

                    string dni = txtDNI.Text;

                    clientes = C_cliente.C_buscarPorDNI_cliente(dni);

                    foreach (Cliente cliente in clientes)
                    {

                        dgbListaCliente.Rows.Add(dgbListaCliente.Rows.Count
                                          , cliente.Nombre
                                          , cliente.Apellido
                                          , cliente.Dni
                                          , cliente.Idcliente);



                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "aviso");
            }

        }

        private void dgbListaCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.id = Convert.ToInt16(dgbListaCliente.Rows[e.RowIndex].Cells["IdCliente"].Value.ToString());
            this.Close();

        }


        private void FrmMantenimientoBuscarCliente_Load(object sender, EventArgs e)
        {
            txtRUC.Visible = false;
            label1.Visible = false;
            dgvListaRuc.Visible = false;
        }


      

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsNumber((e.KeyChar)) && (Convert.ToInt32((e.KeyChar)) != 8)))
            {
                e.Handled = true;
            }
        }

        private void dgbListaCliente_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {

                if (e.KeyCode == Keys.Return)
                {

                    this.id = Convert.ToInt16(dgbListaCliente.CurrentRow.Cells["IdCliente"].Value.ToString());
                    this.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "aviso");
            }
        }

        private void rbEmpresa_CheckedChanged(object sender, EventArgs e)
        {
            dgbListaCliente.Rows.Clear();
            txtDNI.Clear();
            txtRUC.Visible = true;
            label1.Visible = true;
            txtDNI.Visible = false;
            label3.Visible = false;
            dgvListaRuc.Visible = true;
            dgbListaCliente.Visible = false;
        }

        private void rbCliente_CheckedChanged(object sender, EventArgs e)
        {
            dgvListaRuc.Rows.Clear();
            txtRUC.Clear();
            txtDNI.Visible = true;
            label3.Visible = true;
            txtRUC.Visible = false;
            label1.Visible = false;
            dgvListaRuc.Visible = false;
            dgbListaCliente.Visible = true;

        }
    

        ////////////////////////////////////////////////////////////////////////////////////////////////////////
   
        private void txtRUC_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                // detectar si ha presionado la tecla enter
                if (e.KeyCode == Keys.Return)
                {

                    dgvListaRuc.Rows.Clear();

                    C_Cliente C_cliente = new C_Cliente();
                    List<Cliente> clientes = new List<Cliente>();

                    string ruc = txtRUC.Text;

                    clientes = C_cliente.C_buscarPorRuc_cliente(ruc);

                    foreach (Cliente cliente in clientes)
                    {

                        dgvListaRuc.Rows.Add(dgvListaRuc.Rows.Count
                                          , cliente.Ruc
                                          , cliente.Razonsocial
                                          , cliente.Idcliente
                                          );
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "aviso");
            }


        }

        private void dgvListaRuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.id = Convert.ToInt16(dgvListaRuc.Rows[e.RowIndex].Cells["IdClienteRUC"].Value.ToString());
            this.Close();
        }

        private void txtRUC_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if ((!Char.IsNumber((e.KeyChar)) && (Convert.ToInt32((e.KeyChar)) != 11)))
            //{
            //    e.Handled = true;
            //}
        }

        private void dgvListaRuc_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {

                    this.id = Convert.ToInt16(dgvListaRuc.CurrentRow.Cells["IdClienteRUC"].Value.ToString());
                    this.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "aviso");
            }
        }

        private void dgvListaRuc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

 
    }

}
