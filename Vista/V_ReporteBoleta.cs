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
    public partial class V_ReporteBoleta : Form
    {
        public int idVenta = 0;

        public V_ReporteBoleta()
        {
            InitializeComponent();
        }

        private void FrmReporteBoleta_Load(object sender, EventArgs e)
        {
            frodriguezDataSet1 ds = new frodriguezDataSet1();
            C_Reporte C_reporte = new C_Reporte();
            ds = C_reporte.C_reporte_Boleta(this.idVenta);
            CRReporteBoleta rpt = new CRReporteBoleta();
            rpt.SetDataSource(ds);
            crystalReportViewerBoleta.ReportSource = rpt;
        }
    }
}
