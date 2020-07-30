using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Rodriguez.Modelo;
using Rodriguez.Entitites;

namespace Rodriguez.Controlador
{
    class C_Producto
    {

        public Int32 C_registrar_producto(Producto producto)
        {
            try
            {
                Int32 resp = 0;

                M_Producto M_producto = new M_Producto();
                resp = M_producto.M_registrar_Producto(producto);


                return resp;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        ////////////////////////////////////////////////////////

        public Int32 C_actualizar_producto(Producto producto)
        {


            try
            {
                Int32 resp = 0;

                M_Producto M_producto = new M_Producto();
                resp = M_producto.M_actualizar_Producto(producto);


                return resp;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        ////////////////////////////////////////////////////

        public Int32 C_eliminar_producto(Int16 idProducto)
        {


            try
            {
                Int32 resp = 0;

                M_Producto M_producto = new M_Producto();
                resp = M_producto.M_Eliminar_Producto(idProducto);


                return resp;

            }
            catch (Exception)
            {

                //throw new Exception(ex.Message);
                throw;
            }
        }

        ////////////////////////////////
        public Producto C_buscarPorId_producto(Int16 idProducto)
        {


            try
            {
                Producto producto = new Producto();

                M_Producto M_producto = new M_Producto();
                producto = M_producto.M_BuscarPorId_Producto(idProducto);


                return producto;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////

        public List<Producto> C_buscarPorNombre_producto(string nombre)
        {


            try
            {
                List<Producto> productos = new List<Producto>();

                M_Producto M_producto = new M_Producto();
                productos = M_producto.M_BuscarPorNombre_Producto(nombre);


                return productos;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        //////////////////////////////////////////////////////////////////////////////

        public List<Producto> C_ListaTop_ProductosFechas(DateTime fechaIni, DateTime fechaFin)
        {


            try
            {
                List<Producto> productos = new List<Producto>();

                M_Producto M_producto = new M_Producto();
                productos = M_producto.M_ListaTopProductos_Fechas(fechaIni, fechaFin);


                return productos;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

    }
}
