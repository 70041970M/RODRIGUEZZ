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
    public partial class V_BuscarBoletasPorNombreCliente : Form
    {
        public Int16 id = -1;
        
        public V_BuscarBoletasPorNombreCliente()
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
            string nombre = txtCliente.Text;
            ventas = C_venta.C_BoletaBuscar_PorNombreCliente(nombre);
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
            btnimprimir.Enabled = true;
            }
             catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "aviso");
            }

        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmBuscarBoletasPorNombreCliente_Load(object sender, EventArgs e)
        {
            btnimprimir.Enabled = false;
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            string idcli = txtIdVenta.Text;
            if (idcli == "0")
            {
                MessageBox.Show("Por favor seleccione una boleta", "aviso");

            }
            else
            {
                V_ReporteBoleta form = new V_ReporteBoleta();
                form.idVenta = Convert.ToInt32(txtIdVenta.Text);
                form.Show();
            }
        }

        private void dgbListaCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdVenta.Text = dgbListaCliente.Rows[e.RowIndex].Cells["idventa"].Value.ToString();
        }

        private void txtIdVenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
