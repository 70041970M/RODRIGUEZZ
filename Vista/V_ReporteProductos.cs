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
    public partial class V_ReporteProductos : Form
    {
        public V_ReporteProductos()
        {
            InitializeComponent();
        }

        private void FrmReporteProductos_Load(object sender, EventArgs e)
        {
            frodriguezDataSet1 ds = new frodriguezDataSet1();
            C_Reporte C_reporte = new C_Reporte();
            ds = C_reporte.C_listar_Productos();

            ReporteProductos rpt = new ReporteProductos();
            rpt.SetDataSource(ds);
            crystalReportViewerProducto.ReportSource = rpt;
             
           
        }
    }
}
