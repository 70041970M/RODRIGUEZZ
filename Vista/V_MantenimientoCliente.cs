using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Rodriguez.Controlador;
using Rodriguez.Utilities;
using Rodriguez.Entitites;
using Rodriguez.Modelo;

namespace Rodriguez.Vista
{
    public partial class V_MantenimientoCliente : Form
    {
        

        public V_MantenimientoCliente()
        {
            InitializeComponent();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //if (rbCliente.Checked == true)
            //{
                //if (txtDNICli.Text == "")
                //{
                //    MessageBox.Show("EL campo DNI no debe estar nulo ni vacio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //}
                
            //}
            //else if (rbEmpresa.Checked == true)
            //    {
                    //if ()
                    //{
                    //    MessageBox.Show("EL campo RUC no debe estar nulo ni vacio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //}
                //}
            
                    
                try
                {
                    Int16 id;
                    Int16.TryParse(txtIdCliente.Text, out id);

                    //---creamos un objeto cliente
                    Cliente cliente = new Cliente();

                    //--- llenar de datos al objeto cliente

                    cliente.Dni = txtDNICli.Text;
                    cliente.Nombre = txtNommbreCli.Text.ToUpper();
                    cliente.Apellido = txtApellidosCli.Text.ToUpper();
                    cliente.Direccion = txtDireccionCli.Text.ToUpper();
                    cliente.Telefono = txtTelefonoCli.Text.ToUpper();
                    cliente.Correo = txtCorreoCli.Text.ToUpper();
                    cliente.Ruc = txtRuc.Text.ToUpper();
                    cliente.Razonsocial = txtrazonsocial.Text.ToUpper();



                    C_Cliente clienteBLL = new C_Cliente();


                    if (id == 0)
                    {



                        //--insertar----
                        Int32 resp = clienteBLL.C_insertar_cliente(cliente);
                        txtIdCliente.Text = cliente.Idcliente.ToString();
                        MessageBox.Show("CLIENTE REGISTRADO SATISFACTORIAMENTE", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    else
                    {
                        //----actualizado
                        cliente.Idcliente = id;
                        Int32 resp = clienteBLL.C_actualizar_cliente(cliente);
                        MessageBox.Show("CLIENTE ACTUALIZADO SATISFACTORIAMENTE", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                }

                catch (Exception ex)
                {

                    //MessageBox.Show("EL DNI/RUC YA SE ENCUENTRA REGISTRADO, POR FAVOR INGRESE DNI CORRECTO", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning
                    MessageBox.Show(ex.Message /*+ "-" + ex.StackTrace.ToString()*/);


                }

        }






        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                Int16 id;
                Int16.TryParse(txtIdCliente.Text, out id);


                if (id > 0)
                {

                    DialogResult dialog;
                    dialog = MessageBox.Show("¿Esta seguro de eliminar este registro?"
                                            , "Confirmacion"
                                            , MessageBoxButtons.YesNo
                                            , MessageBoxIcon.Question);


                    if (dialog == DialogResult.Yes)
                    {

                        C_Cliente clienteBLL = new C_Cliente();
                        clienteBLL.C_eliminar_cliente(id);

                        MessageBox.Show("CLIENTE ELIMINADO SATISFACTORIAMENTE", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.txtIdCliente.Clear();
                        this.txtNommbreCli.Clear();
                        this.txtApellidosCli.Clear();
                        this.txtDNICli.Clear();
                        this.txtDireccionCli.Clear();
                        this.txtTelefonoCli.Clear();
                        this.txtCorreoCli.Clear();
                        this.txtRuc.Clear();
                        this.txtrazonsocial.Clear();
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

                V_MantenimientoBuscarCliente form;
                form = new V_MantenimientoBuscarCliente();

                form.ShowDialog(this);


                if (form.id > 0)
                {

                    C_Cliente C_cliente = new C_Cliente();
                    Cliente cliente = C_cliente.C_buscarPorId_cliente(form.id);

                  
                    txtIdCliente.Text = cliente.Idcliente.ToString();
                    txtDNICli.Text= cliente.Dni.ToString();
                    txtNommbreCli.Text = cliente.Nombre.ToString();
                    txtApellidosCli.Text = cliente.Apellido.ToString();
                    txtDireccionCli.Text = cliente.Direccion.ToString();
                    txtTelefonoCli.Text = cliente.Telefono.ToString();
                    txtCorreoCli.Text = cliente.Correo.ToString();
                    txtRuc.Text = cliente.Ruc.ToString();
                    txtrazonsocial.Text = cliente.Razonsocial.ToString();


                    txtDNICli.Enabled = false;
                    txtRuc.Enabled = false;
               
                }
             }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "aviso");

            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea registrar nuevo cliente?", "Nuevo Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                this.txtIdCliente.Clear();
                this.txtNommbreCli.Clear();
                this.txtApellidosCli.Clear();
                this.txtDNICli.Clear();
                this.txtDireccionCli.Clear();
                this.txtTelefonoCli.Clear();
                this.txtCorreoCli.Clear();
                this.txtRuc.Clear();
                this.txtrazonsocial.Clear();
                txtDNICli.Enabled = true;
                txtRuc.Enabled = true;
            }
            else result = DialogResult.No;
        }

        private void FrmMantenimientoCliente_Load(object sender, EventArgs e)
        {
            txtRuc.Visible = false;
            label8.Visible = false;
            txtrazonsocial.Visible = false;
            label1.Visible = false;
              

        }

        private void txtDNICli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsNumber((e.KeyChar)) && (Convert.ToInt32((e.KeyChar)) != 8)))
            {
                e.Handled = true;
            }
        }

        private void txtIdCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rbCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbCliente.Checked == true)
            {
                txtRuc.Visible = false;
                label8.Visible = false;
               // txtRazonsocial.Enabled = false;
                //txtDNICli.Enabled = true;
                //txtApellidosCli.Enabled = true;
                //txtNommbreCli.Enabled = true;
                txtDNICli.Visible = true;
                label2.Visible = true;
                txtrazonsocial.Visible = false;
                label1.Visible = false;
                txtNommbreCli.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                txtApellidosCli.Visible = true;

                txtRuc.Clear();
                txtrazonsocial.Clear();
                txtDireccionCli.Clear();
                txtTelefonoCli.Clear();
                txtCorreoCli.Clear();

                txtDNICli.Enabled = true;
                txtRuc.Enabled = true;
                txtIdCliente.Clear();

                
            }
        }

        private void rbEmpresa_CheckedChanged(object sender, EventArgs e)
        {

                //txtRazonsocial.Enabled = true;
                //txtDNICli.Enabled = false;
               
                //txtNommbreCli.Enabled = true;
                txtRuc.Visible = true;
                label8.Visible = true;
                txtDNICli.Visible = false;
                label2.Visible = false;
                txtrazonsocial.Visible = true;
                label1.Visible = true;
                txtNommbreCli.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                txtApellidosCli.Visible = false;

                txtDNICli.Clear();
                txtNommbreCli.Clear();
                txtApellidosCli.Clear();
                txtDireccionCli.Clear();
                txtTelefonoCli.Clear();
                txtCorreoCli.Clear();

                txtDNICli.Enabled = true;
                txtRuc.Enabled = true;
                txtIdCliente.Clear();
           
        }

        private void txtRuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if ((!Char.IsNumber((e.KeyChar)) && (Convert.ToInt32((e.KeyChar)) != 11)))
            //{
            //    e.Handled = true;
            //}
        }

        private void txtNommbreCli_TextChanged(object sender, EventArgs e)
        {

        }

  

        //--------------------------------------------------------------------------------
        //protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        //{
        //    if ((keyData != Keys.F1) & (keyData != Keys.F2) & (keyData != Keys.F3))
        //    {
        //        return base.ProcessCmdKey(ref msg, keyData);
        //    }


        //    if (keyData == Keys.F1)
        //    {

        //        btnGuardar.PerformClick();

        //    }

        //    if (keyData == Keys.F2)
        //    {


        //        btnEliminar.PerformClick();
        //    }

        //    if (keyData == Keys.F3)
        //    {

        //        btnBuscar.PerformClick();

        //    }


        //    if (keyData == Keys.Escape)
        //    {
        //        //-- cerrar la ventana

        //        this.Close();

        //    }



        //    return true;
        //}


    }
}
