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
    public partial class V_BuscarFacturaPorRazonSocial : Form
    {
        public V_BuscarFacturaPorRazonSocial()
        {
            InitializeComponent();
        }

        private void bnBuscar_Click(object sender, EventArgs e)
        {
             try
            {
            dgbListaCliente.Rows.Clear();
            C_Venta C_venta = new C_Venta();
            List<Venta> ventas = new List<Venta>();
            string razonsocial = txtRazonSocial.Text;
            ventas = C_venta.C_FacturaBuscar_PorRazonSocial(razonsocial);
            foreach (Venta venta in ventas)
            {
                dgbListaCliente.Rows.Add(dgbListaCliente.Rows.Count
                                  , venta.Comprobante
                                  //, venta.Cliente.Idcliente
                                  //, venta.Serie
                                  //, venta.Numero
                                  , venta.FechaVenta
                                  //, venta.Cliente.Apellido
                                  //, venta.Cliente.Nombre
                                  //, venta.Cliente.Dni
                                  , venta.IdVenta
                                  );
                
            }
            }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message, "aviso");
             }
      
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            string idcli = txtIdVenta.Text;
            if (idcli == "0")
            {
                MessageBox.Show("Por favor seleccione una factura", "aviso");

            }
            else
            {
                V_ReporteFactura form = new V_ReporteFactura();
                form.idVenta = Convert.ToInt32(txtIdVenta.Text);
                form.Show();
            }
        }

        private void dgbListaCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdVenta.Text = dgbListaCliente.Rows[e.RowIndex].Cells["idventa"].Value.ToString();
        }

        private void FrmBuscarFacturaPorRazonSocial_Load(object sender, EventArgs e)
        {
            btnimprimir.Enabled = false;
        }
    }
}
