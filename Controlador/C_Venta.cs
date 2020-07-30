using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Rodriguez.Modelo;
using Rodriguez.Entitites;

namespace Rodriguez.Controlador
{
    class C_Venta
    {
        public Venta C_generarSerie_NumeroComprobante(string tipoComprobante)
        {
            try
            {
                Venta venta = new Venta();
                M_Venta M_venta = new M_Venta();
                venta = M_venta.M_generarSerie_NumeroComprobante(tipoComprobante);
                return venta;
            }
            catch (Exception )
            {
                throw;
            }
        }


        public Int32 c_insertar_venta(Venta venta)
        {
            try
            {
                Int32 resp = 0;
                M_Venta M_venta = new M_Venta();
                resp = M_venta.M_insertar_venta(venta);
                return resp;

            }
            catch (Exception)
            {

                throw;
            }

        }


        public List<Venta> C_BoletaBuscar_PorNombreCliente(string nombre){
            try
            {
                List<Venta> ventas = new List<Venta>();

                M_Venta M_venta = new M_Venta();
                ventas = M_venta.M_BoletaBuscar_PorNombreCliente(nombre);


                return ventas;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public List<Venta> C_FacturaBuscar_PorRazonSocial(string razonsocial)
        {
            try
            {
                List<Venta> ventas = new List<Venta>();

                M_Venta M_venta = new M_Venta();
                ventas = M_venta.M_FacturaBuscar_PorRazonSocial(razonsocial);


                return ventas;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
