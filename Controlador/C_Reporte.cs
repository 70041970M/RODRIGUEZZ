using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rodriguez.Modelo;
using Rodriguez.Entitites;

namespace Rodriguez.Controlador
{
    class C_Reporte
    {
        public frodriguezDataSet1 C_listar_ClientesEmpresa(DateTime fechaIni, DateTime fechaFin)
        {
            try
            {
                frodriguezDataSet1 ds = new frodriguezDataSet1();
                M_Reporte M_reporte = new M_Reporte();
                ds = M_reporte.M_listar_ClientesEmpresa(fechaIni, fechaFin);
                return ds;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //////////////////////////////////////
        public frodriguezDataSet1 C_listar_ClientesNatural(DateTime fechaIni, DateTime fechaFin)
        {
            try
            {
                frodriguezDataSet1 ds = new frodriguezDataSet1();
                M_Reporte M_reporte = new M_Reporte();
                ds = M_reporte.M_listar_ClientesNatural(fechaIni, fechaFin);
                return ds;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //////////////////////////////////////
        public frodriguezDataSet1 C_Top_ProductosPorFechas(DateTime fechaIni, DateTime fechaFin)
        {
            try
            {
                frodriguezDataSet1 ds = new frodriguezDataSet1();
                M_Reporte M_reporte = new M_Reporte();
                ds = M_reporte.M_Top_ProductosPorFechas(fechaIni, fechaFin);
                return ds;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////
        public frodriguezDataSet1 C_listar_Productos()
        {
            try
            {
                frodriguezDataSet1 ds = new frodriguezDataSet1();
                M_Reporte M_reporte = new M_Reporte();
                ds = M_reporte.M_listar_Productos();
                return ds;
            }
            catch (Exception)
            {
                throw;
            }
        }

        ////////////////////////////////

        public frodriguezDataSet1 C_listar_Empleados()
        {
            try
            {
                frodriguezDataSet1 ds = new frodriguezDataSet1();
                M_Reporte M_reporte = new M_Reporte();
                ds = M_reporte.M_listar_Empleados();
                return ds;
            }
            catch (Exception)
            {
                throw;
            }
        }

        ////////////////////////////////////////////////////

        public frodriguezDataSet1 C_listar_ProductosStock()
        {
            try
            {
                frodriguezDataSet1 ds = new frodriguezDataSet1();
                M_Reporte M_reporte = new M_Reporte();
                ds = M_reporte.M_listar_ProductosStock();
                return ds;
            }
            catch (Exception)
            {
                throw;
            }
        }



        //////////////////////////////////////////////////////////



        public frodriguezDataSet1 C_reporte_Factura(int idVenta)
        {

            frodriguezDataSet1 ds = new frodriguezDataSet1();

            try
            {
                M_Reporte M_reporte = new M_Reporte();

                ds = M_reporte.M_reporte_Factura(idVenta);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            return ds;

        }

        public frodriguezDataSet1 C_reporte_Boleta(int idVenta)
        {

            frodriguezDataSet1 ds = new frodriguezDataSet1();

            try
            {
                M_Reporte M_reporte = new M_Reporte();

                ds = M_reporte.M_reporte_Boleta(idVenta);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            return ds;

        }
    }
}
