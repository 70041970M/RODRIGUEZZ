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
    public partial class V_ProcesoVenta : Form
    {
        public V_ProcesoVenta()
        {
            InitializeComponent();
        }


        private void calcularTotal()
        {
            txtTotal.Text = string.Empty;
            txtValorIGV.Text = string.Empty;
            txtSubtotal.Text = string.Empty;
            decimal total = 0;
            foreach (DataGridViewRow row in dgvLista.Rows)
            {
                total = total + Decimal.Parse(row.Cells["subtotal"].Value.ToString());

            }


            string tipoComprobante = cboTipoComprobante.Text;


            if (tipoComprobante.CompareTo("FACTURA") == 0)
            {

                decimal tasaIGV = Decimal.Parse(txtIGV.Text);
                decimal valorIGV = total * tasaIGV / 100;
                decimal subtotal = total - valorIGV;


                txtTotal.Text = total.ToString();
                txtValorIGV.Text = valorIGV.ToString();
                txtSubtotal.Text = subtotal.ToString();

            }
            else
            {
                txtTotal.Text = total.ToString();
            }


        }


        private void btnabrirformcliente_Click(object sender, EventArgs e)
        {
            string tipoComprobante = cboTipoComprobante.Text;
            if (tipoComprobante =="BOLETA") {
         
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
                    txtNombreCliente.Text = cliente.Nombre.ToString();
                    txtApellidoCliente.Text = cliente.Apellido.ToString();

                }
            }
            

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "aviso");

            }

            }
            else if (tipoComprobante == "FACTURA")
                //----------------------------------------------------

                
                 try
                {

                    V_MantenimientoBuscarCliente form;
                    form = new V_MantenimientoBuscarCliente();

                    form.ShowDialog(this);


                    if (form.id > 0)
                    {

                        C_Cliente clienteBLL = new C_Cliente();
                        Cliente cliente = clienteBLL.C_buscarPorId_cliente(form.id);

                        txtIdCliente.Text = cliente.Idcliente.ToString();
                        txtRUC.Text = cliente.Ruc.ToString();
                        txtRazonSocial.Text = cliente.Razonsocial.ToString();

                    }
                }


                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "aviso");

                }

            //-----------------------------------------------------------
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {


            try
            {
                V_MantenimientoBuscarProductoVenta form;
                form = new V_MantenimientoBuscarProductoVenta();
                form.ShowDialog(this);
                if (form.idProducto_ > 0)
                {


                    foreach (DataGridViewRow row in dgvLista.Rows)
                    {

                        if(form.idProducto_ ==Int32 .Parse(row.Cells["idpv"].Value.ToString())){
                        MessageBox.Show( "El producto ya se encuentra en la lista");
                        return ;
                        
                        }
                     
                    }
                    
                    dgvLista.Rows.Add
                        (
                         dgvLista.Rows.Count + 1,
                         form.idProducto_,
                         form.nombreProducto_,
                         form.precioProducto_,
                         form.cantidadProducto_,
                         form.precioProducto_ * form.cantidadProducto_
                        );
                }

                calcularTotal();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "aviso");
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

                    Int16 idCliente;
                    Int16.TryParse(txtIdCliente.Text, out idCliente);

                    if (idCliente == 0)
                    {
                        MessageBox.Show("Ingrese Cliente", "Aviso");
                        return;
                    }

                    if (dgvLista.Rows.Count == 0)
                    {
                        MessageBox.Show("Ingrese Productos /Servicios", "Aviso");
                        return;
                    }

                    Venta venta = new Venta();
                    venta.Cliente = new Cliente();
                    venta.VentaDetalles = new List<VentaDetalle>();
                    venta.FechaVenta = dtpFecha.Value;
                    venta.Cliente.Idcliente = idCliente;

                    venta.Serie = txtSerie.Text;
                    venta.Numero = txtNumero.Text;
                    venta.TipoComprobante = cboTipoComprobante.Text.Substring(0, 1);
                    decimal igv = 0;
                    decimal.TryParse(txtIGV.Text, out igv);
                    venta.Igv = igv / 100;



                    foreach (DataGridViewRow row in dgvLista.Rows)
                    {

                        VentaDetalle ventaDetalle = new VentaDetalle();
                        ventaDetalle.Producto = new Producto();

                        ventaDetalle.Producto.Idproducto = Int16.Parse(row.Cells["idpv"].Value.ToString());

                        ventaDetalle.Cantidad = Int32.Parse(row.Cells["cantidad"].Value.ToString());
                        ventaDetalle.PrecioUnitario = Decimal.Parse(row.Cells["preciopv"].Value.ToString());
                        venta.VentaDetalles.Add(ventaDetalle);
                    }
                    C_Venta C_venta = new C_Venta();
                    C_venta.insertar(venta);
                    txtIdVenta.Text = venta.IdVenta.ToString();

                    MessageBox.Show("VENTA  REALIZADA SATISFACTORIAMENTE", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    DialogResult result = MessageBox.Show("¿Desea imprimir?", "Imprimir Documento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {

                    //---------------- imprimir--------------------------

                     try
                      {
                        string tipoComprobante = cboTipoComprobante.Text;
                        if (tipoComprobante.CompareTo("FACTURA") == 0)
                        {
                            V_ReporteFactura form = new V_ReporteFactura();
                            form.idVenta = Convert.ToInt32(txtIdVenta.Text);
                            form.Show();
                        }
                        else
                        {
                            V_ReporteBoleta form = new V_ReporteBoleta();
                            form.idVenta = Convert.ToInt32(txtIdVenta.Text);
                            form.Show();

                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }

                    //--------------------------------------------------------


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else result = DialogResult.No;
            {
                this.Close();
            }
        }


        private void FrmProcesoVenta_Load(object sender, EventArgs e)
        {
            try
            {
                cboTipoComprobante.SelectedIndex = 1;
                label7.Visible = true;
                label2.Visible = true;
                txtNombreCliente.Visible = true;
                txtApellidoCliente.Visible = true;
                lblRuc.Visible = false;
                lblRazonSocial.Visible = false;
                txtRUC.Visible = false;
                txtRazonSocial.Visible = false;

                string tipoComprobante = cboTipoComprobante.Text.Substring(0, 1);
                C_Venta C_venta = new C_Venta();
                Venta venta = new Venta();

                venta = C_venta.C_generarSerie_NumeroComprobante(tipoComprobante);
                txtSerie.Text = venta.Serie;
                txtNumero.Text = venta.Numero;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "-" + ex.StackTrace.ToString());
            }
        }

       

        private void cboTipoComprobante_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                string tipoComprobante = cboTipoComprobante.Text.Substring(0, 1);
                C_Venta C_venta = new C_Venta();
                Venta venta = new Venta();

                venta = C_venta.C_generarSerie_NumeroComprobante(tipoComprobante);
                txtSerie.Text = venta.Serie;
                txtNumero.Text = venta.Numero;

                if (tipoComprobante.CompareTo("F") == 0)
                {
                    
                    txtIGV.Text = "18";

                    txtSubtotal.Visible = true;
                    txtValorIGV.Visible = true;
                    lblSubtotal.Visible = true;
                    lblValorIGV.Visible = true;

                    label7.Visible = false;
                    label2.Visible = false;
                    txtNombreCliente.Visible = false;
                    txtApellidoCliente.Visible = false;
                    lblRuc.Visible = true;
                    lblRazonSocial.Visible = true;
                    txtRUC.Visible = true;
                    txtRazonSocial.Visible = true;

                }
                else
                {
                    lblIGV.Visible = false;
                    txtIGV.Visible = false;

                    txtIGV.Text = "0";
                    txtSubtotal.Visible = false;
                    txtValorIGV.Visible = false;
                    lblSubtotal.Visible = false;
                    lblValorIGV.Visible = false;

                    label7.Visible = true;
                    label2.Visible = true;
                    txtNombreCliente.Visible = true;
                    txtApellidoCliente.Visible = true;
                    lblRuc.Visible = false;
                    lblRazonSocial.Visible = false;
                    txtRUC.Visible = false;
                    txtRazonSocial.Visible = false;

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void dgvLista_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            calcularTotal();
        }


     

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            V_MantenimientoCliente form;
            form = new V_MantenimientoCliente();
            form.ShowDialog(this);

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
             DialogResult result = MessageBox.Show("¿Desea hacer nueva venta?", "Imprimir Documento", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             if (result == DialogResult.Yes)
             {

                 //this.txtSerie.Clear();
                 //this.txtNumero.Clear();
                 this.cboTipoComprobante.SelectedIndex = 1;
                 this.txtNombreCliente.Clear();
                 this.txtApellidoCliente.Clear();
                 this.txtTotal.Clear();
                 this.txtSubtotal.Clear();
                 this.txtIGV.Clear();
                 this.dgvLista.Rows.Clear();

             }
             if(result == DialogResult.No)
             {
                 this.Close();
             }
            
        }

        private void dgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }






       
        }
    }

