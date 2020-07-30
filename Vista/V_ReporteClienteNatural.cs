using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rodriguez.Modelo;

using Rodriguez.Controlador;
using Rodriguez.Utilities;
using Rodriguez.Entitites;
using Rodriguez.Reports;



namespace Rodriguez.Vista
{
    public partial class V_ReporteClienteNatural : Form
    {

        public DateTime fechaIni;
        public DateTime fechaFin;
        public V_ReporteClienteNatural()
        {
            InitializeComponent();
        }

        private void FrmReporteClienteNatural_Load(object sender, EventArgs e)
        {
            frodriguezDataSet1 ds = new frodriguezDataSet1();
            C_Reporte C_reporte = new C_Reporte();
            ds = C_reporte.C_listar_ClientesNatural(fechaIni, fechaFin);
            ReporteClienteNatural rpt = new ReporteClienteNatural();
            rpt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
