using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rodriguez.Modelo;
using Rodriguez.Entitites;


namespace Rodriguez.Controlador
{
    class C_Cliente
    {
        public Int32 C_insertar_cliente(Cliente cliente)
        {


            try
            {
                Int32 resp = 0;
                M_Cliente M_cliente = new M_Cliente();
                resp = M_cliente.M_insertar_cliente(cliente);
                return resp;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
          
        //////////////////////////////////////////////////////////////////////////////////////////


        public Int32 C_actualizar_cliente(Cliente cliente)
        {


            try
            {
                Int32 resp = 0;

                M_Cliente M_cliente = new M_Cliente();
                resp = M_cliente.M_actualizar_cliente(cliente);


                return resp;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////
        public Int32 C_eliminar_cliente(Int16 idCliente)
        {


            try
            {
                Int32 resp = 0;

                M_Cliente M_cliente = new M_Cliente();
                resp = M_cliente.M_eliminar_cliente(idCliente);


                return resp;

            }
            catch (Exception )
            {
                throw;
                //throw new Exception(ex.Message);
            }
        }



        //////////////////////////////////////////////////////////////////////////////////////////
        public List<Cliente> C_buscarPorDNI_cliente(string dni)
        {


            try
            {
                List<Cliente> clientes = new List<Cliente>();

                M_Cliente M_cliente = new M_Cliente();
                clientes = M_cliente.M_buscarPorDNI_cliente(dni);


                return clientes;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////

        public Cliente C_buscarPorId_cliente(Int16 idCliente)
        {


            try
            {
                Cliente cliente = new Cliente();

                M_Cliente M_cliente = new M_Cliente();
                cliente = M_cliente.M_buscarPorId_cliente(idCliente);


                return cliente;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////

        public List<Cliente> C_buscarPorRuc_cliente(string ruc)
        {


            try
            {
                List<Cliente> clientes = new List<Cliente>();

                M_Cliente M_cliente = new M_Cliente();
                clientes = M_cliente.M_buscarPorRuc_cliente(ruc);


                return clientes;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        ///////////////////////////////
        public List<Cliente> C_Buscar_clienteNatural(DateTime fechaIni, DateTime fechaFin)
        {


            try
            {
                List<Cliente> clientes = new List<Cliente>();

                M_Cliente M_cliente = new M_Cliente();
                clientes = M_cliente.M_Buscar_clienteNatural( fechaIni, fechaFin);


                return clientes;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        ///////////////////////////////

        public List<Cliente> C_Buscar_clienteEmpresa(DateTime fechaIni, DateTime fechaFin)
        {


            try
            {
                List<Cliente> clientes = new List<Cliente>();

                M_Cliente M_cliente = new M_Cliente();
                clientes = M_cliente.M_Buscar_clienteEmpresa(fechaIni, fechaFin);


                return clientes;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        ///////////////////////////////

    }
}
