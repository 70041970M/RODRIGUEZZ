using Rodriguez.Controlador;
using Rodriguez.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rodriguez.Vista
{
    public partial class V_ReporteFactura : Form
    {
        public int idVenta=0;

        public V_ReporteFactura()
        {
            InitializeComponent();
        }

        private void FrmReporteFactura_Load(object sender, EventArgs e)
        {
         
                    frodriguezDataSet1 ds = new frodriguezDataSet1();
                    C_Reporte C_reporte = new C_Reporte();

                    ds = C_reporte.C_reporte_Factura(this.idVenta);


                    CRReporteFactura rpt = new CRReporteFactura();

                    rpt.SetDataSource(ds);

                    crystalReportViewerFactura.ReportSource = rpt;
                
        }

       
    }
}
