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
    public partial class V_TopProductos : Form
    {

        public DateTime fechaIni;
        public DateTime fechaFin;
        public V_TopProductos()
        {
            InitializeComponent();
        }

        private void FrmTopProductos_Load(object sender, EventArgs e)
        {

            frodriguezDataSet1 ds = new frodriguezDataSet1();
            C_Reporte C_reporte = new C_Reporte();
            ds = C_reporte.C_Top_ProductosPorFechas(fechaIni, fechaFin);
            ReporteTopProductos rpt = new ReporteTopProductos();
            rpt.SetDataSource(ds);
            crystalTopProductos.ReportSource = rpt;
        }
    }
}
