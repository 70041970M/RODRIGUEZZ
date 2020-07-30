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
    public partial class V_ListarProductosPorFecha : Form
    {
        public V_ListarProductosPorFecha()
        {
            InitializeComponent();
        }

        private void FrmListarProductosPorFecha_Load(object sender, EventArgs e)
        {
            btnimprimir.Enabled = false;
        }

        private void bnBuscar_Click(object sender, EventArgs e)
        {
            dgvProductos.Rows.Clear();
            dgvProductos.Rows.Clear();


            C_Producto C_producto = new C_Producto();
            List<Producto> productos = new List<Producto>();

            DateTime fechaIni = dtpini.Value;
            DateTime fechaFin = dtpfin.Value;


            productos = C_producto.C_ListaTop_ProductosFechas(fechaIni, fechaFin);

            foreach (Producto producto in productos)
            {

                dgvProductos.Rows.Add(dgvProductos.Rows.Count
                                  , producto.Nombre
                                  , producto.Diseño
                                  , producto.Material
                                  , producto.Categoria
                                  , producto.Color
                                  , producto.Cantidad
                                  , producto.Idproducto);
            }
            btnimprimir.Enabled = true;
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            V_TopProductos form = new V_TopProductos();
            form.fechaIni = Convert.ToDateTime(dtpini.Value);
            form.fechaFin = Convert.ToDateTime(dtpfin.Value);
            form.Show();
        }
    }
}
