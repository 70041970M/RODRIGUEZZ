using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Rodriguez.Modelo;
using Rodriguez.Entitites;


namespace Rodriguez.Controlador
{
    class C_Empleado
    {

        public Int32 C_cambiarClave_empleado(string claveActual, string claveNueva)
        {

            try
            {

                Int32 resp = 0;

                M_Empleado M_empleado = new M_Empleado();

                resp = M_empleado.M_cambiarClave_empleado(claveActual, claveNueva);

                return resp;

            }
            catch (Exception)
            {

                throw;
            }

        }




        public Int32 C_insertar_empleado(Empleado empleado)
        {


            try
            {
                Int32 resp = 0;

                M_Empleado M_empleado = new M_Empleado();
                resp = M_empleado.M_insertar_empleado(empleado);


                return resp;

            }
            catch (Exception )
            {

                throw ;
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////


        public Int32 C_actualizar_empleado(Empleado empleado)
        {


            try
            {
                Int32 resp = 0;

                M_Empleado M_empleado = new M_Empleado();
                resp = M_empleado.M_actualizar_empleado(empleado);


                return resp;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////

        public Int32 C_eliminar_empleado(Int16 idEmpleado)
        {


            try
            {
                Int32 resp = 0;

                M_Empleado M_empleado = new M_Empleado();
                resp = M_empleado.M_eliminar_empleado(idEmpleado);


                return resp;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }



        //////////////////////////////////////////////////////////////////////////////////////////

        public List<Empleado> C_buscarPorDNI_empleado(string dni)
        {


            try
            {
                List<Empleado> empleados = new List<Empleado>();

                M_Empleado M_empleado = new M_Empleado();
                empleados = M_empleado.M_buscarPorDNI_empleado(dni);


                return empleados;

            }
            catch (Exception)
            {

                throw ;
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////

        public Empleado C_buscarPorId_empleado(Int16 idEmpleado)
        {


            try
            {
                Empleado empleado = new Empleado();

                M_Empleado M_empleado = new M_Empleado();
                empleado = M_empleado.M_buscarPorId_empleado(idEmpleado);


                return empleado;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        //////////////////////////////////////
        public bool C_validar_empleado(Empleado empleado)
        {
            try
            {
                bool resp = false;
                M_Empleado M_empleado = new M_Empleado();
                resp = M_empleado.M_validar_empleado(empleado);
                return resp;
            }
            catch (Exception)
            {
                throw;
            }
        }

        ////////////////////////////////


        public Empleado C_buscarDNIRepetido_empleado(string dni)
        {
            try
            {
                Empleado empleado = new Empleado();

                M_Empleado M_empleado = new M_Empleado();
                empleado = M_empleado.M_buscarDNIRepetido_empleado(dni);


                return empleado;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
