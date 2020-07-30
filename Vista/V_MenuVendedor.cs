using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Rodriguez.Entitites;

namespace Rodriguez.Vista
{
    public partial class V_MenuVendedor : Form
    {
        public V_MenuVendedor()
        {
            InitializeComponent();
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            V_ProcesoVenta form = new V_ProcesoVenta();
            form.MdiParent = this;
            form.Show();

        }

        private void seguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmMenuVendedor_Load(object sender, EventArgs e)
        {
            etiquetaDNI.Text = "DNI: " + EmpleadoLogueado.dni;
            etiquetaNombres.Text = "NOMBRE: " + EmpleadoLogueado.nombre;
            etiquetaApellidos.Text = "APELLIDO: " + EmpleadoLogueado.apellido;
            etiquetaCargo.Text = "CARGO: " + EmpleadoLogueado.cargo;   
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            V_CambiarClave form = new V_CambiarClave();
            form.MdiParent = this;
            form.Show();

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            V_MantenimientoCliente form = new V_MantenimientoCliente();
            form.MdiParent = this;
            form.Show();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            V_MantenimientoProducto form = new V_MantenimientoProducto();
            form.MdiParent = this;
            form.Show();
        }

        private void reporteClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            V_BuscarListarCliente form = new V_BuscarListarCliente();
            form.MdiParent = this;
            form.Show();
        }

        private void reporteProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            V_ReporteProductos form = new V_ReporteProductos();
            form.MdiParent = this;
            form.Show();
        }

        private void productosSinStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            V_ReporteStockProductos form = new V_ReporteStockProductos();
            form.MdiParent = this;
            form.Show();
        }

        private void topProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            V_ListarProductosPorFecha form = new V_ListarProductosPorFecha();
            form.MdiParent = this;
            form.Show();
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            V_BuscarFacturaPorRazonSocial form = new V_BuscarFacturaPorRazonSocial();
            form.MdiParent = this;
            form.Show();
        }

        private void boletasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            V_BuscarBoletasPorNombreCliente form = new V_BuscarBoletasPorNombreCliente();
            form.MdiParent = this;
            form.Show();
        }
    }
}
 