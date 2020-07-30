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
using Rodriguez.Modelo;
using Rodriguez.Vista;
using Rodriguez.Reports;


namespace Rodriguez.Vista
{
    public partial class V_ReporteStockProductos : Form
    {
        public V_ReporteStockProductos()
        {
            InitializeComponent();
        }

        private void FrmReporteStockProductos_Load(object sender, EventArgs e)
        {
            frodriguezDataSet1 ds = new frodriguezDataSet1();
            C_Reporte C_reporte = new C_Reporte();
            ds = C_reporte.C_listar_ProductosStock();

            ReporteStockProductos rpt = new ReporteStockProductos();
            rpt.SetDataSource(ds);
            crvReporteStockProductos.ReportSource = rpt;
             
        }
    }
}
