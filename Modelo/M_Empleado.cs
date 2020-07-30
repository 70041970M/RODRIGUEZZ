using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Rodriguez.Entitites;
using Rodriguez.Connection;
using System.Data;
using System.Data.SqlClient;
using Rodriguez.Utilities;
using System.Windows.Forms;


namespace Rodriguez.Modelo
{
    class M_Empleado
    {
        public Int32 M_cambiarClave_empleado(string claveActual, string claveNueva)
        {


            bool resp = false;

            SqlConnection con = null; // para conectarme a mi BD.

            SqlCommand cmd1; //-- para el select
            SqlCommand cmd2; //-- para el update



            try
            {

                con = UConnection.getConnection();
                con.Open();

                //------- verificar clave actual ---------------

                string sql = "sp_empleado_buscar_por_id";

                cmd1 = new SqlCommand(sql, con);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.Add("@idempleado", SqlDbType.SmallInt).Value = EmpleadoLogueado.idempleado;


                SqlDataReader reader = cmd1.ExecuteReader();

                if (reader.HasRows)
                {

                    string claveAlmacenada = "";
                    while (reader.Read())
                    {
                        claveAlmacenada = Convert.ToString(reader["contrasenia"]);


                    }
                    resp = BCrypt.Net.BCrypt.Verify(claveActual, claveAlmacenada);

                }

                reader.Close();


                if (!resp)
                {
                    throw new Exception("Clave actual es erronea");
                }

                //------ actualizar la clave --------

                string sql2 = "sp_empleado_actualizar_clave";

                cmd2 = new SqlCommand(sql2, con);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.Add("@idempleado", SqlDbType.SmallInt).Value = EmpleadoLogueado.idempleado;

                string claveEncriptada = BCrypt.Net.BCrypt.HashPassword(
                                                                        claveNueva
                                                                        , BCrypt.Net.BCrypt.GenerateSalt()
                                                                        );

                cmd2.Parameters.Add("@contrasenia", SqlDbType.VarChar, 100).Value = claveEncriptada;

                cmd2.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }

            return 0;

        }


        //-------------------------------------------
        public Int32 M_insertar_empleado(Empleado empleado)
        {
            Int32 result = 0; 
            SqlConnection con = null;
            try
            {
                con = UConnection.getConnection();
                con.Open();
                string sql = "sp_empleado_insertar";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@nombree", SqlDbType.VarChar, 50).Value = empleado.Nombre;
                cmd.Parameters.Add("@direccione", SqlDbType.VarChar, 100).Value = empleado.Direccion ;
                cmd.Parameters.Add("@apellidoe", SqlDbType.VarChar, 50).Value = empleado.Apellido;
                cmd.Parameters.Add("@cargoe", SqlDbType.VarChar, 50).Value = empleado.Cargo;
                cmd.Parameters.Add("@telefonoe ", SqlDbType.VarChar, 20).Value = empleado.Telefono;
                cmd.Parameters.Add("@DNI", SqlDbType.VarChar, 8).Value = empleado.Dni;
                cmd.Parameters.Add("@fechanacimiento", SqlDbType.DateTime).Value = empleado.Fechanacimiento;
                cmd.Parameters.Add("@fechaentrada", SqlDbType.DateTime).Value = empleado.Fechaentrada;
                string claveEncriptada = BCrypt.Net.BCrypt.HashPassword(
                                                                      empleado.Contraseña
                                                                      , BCrypt.Net.BCrypt.GenerateSalt()                  
                                                                      );
                cmd.Parameters.Add("@contrasenia", SqlDbType.VarChar, 100).Value = claveEncriptada;
                SqlParameter outParam = cmd.Parameters.Add("@idempleado", SqlDbType.SmallInt);
                outParam.Direction = ParameterDirection.Output;
                result = cmd.ExecuteNonQuery();
                empleado.Idempleado = Convert.ToInt16(cmd.Parameters["@idempleado"].Value);
            }
            catch (Exception ex)
            {
                Logger log = new Logger();
                log.setException(ex);
                throw;
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



        public Int32 M_actualizar_empleado(Empleado empleado)
        {

            Int32 result = 0; // retorno de mi metodo insertar
            SqlConnection con = null; // para conectarme a mi BD.

            try
            {
                // apunta a la conexion de mi BD (direccion, BD, user,clave,)
                con = UConnection.getConnection();

                // abrimos la coneccion a la BD
                con.Open();

                // procedimiento almacenado para insertar cliente
                string sql = "sp_empleado_actualizar";

                // creamos un objeto comando para ejecutar el Procedimiento a.
                SqlCommand cmd = new SqlCommand(sql, con);

                //definir que estamos trabajando con procedimiento almacenados
                cmd.CommandType = CommandType.StoredProcedure;


                // pasar los parametros a mi procedimiento almacenado

                // parametros de entrada
                cmd.Parameters.Add("@nombree", SqlDbType.VarChar, 50).Value = empleado.Nombre;
                cmd.Parameters.Add("@direccione", SqlDbType.VarChar, 100).Value = empleado.Direccion;
                cmd.Parameters.Add("@apellidoe", SqlDbType.VarChar, 50).Value = empleado.Apellido;
                cmd.Parameters.Add("@cargoe", SqlDbType.VarChar, 50).Value = empleado.Cargo;
                cmd.Parameters.Add("@telefonoe ", SqlDbType.VarChar, 20).Value = empleado.Telefono;
                cmd.Parameters.Add("@DNI", SqlDbType.VarChar, 8).Value = empleado.Dni;
                cmd.Parameters.Add("@fechanacimiento", SqlDbType.DateTime).Value = empleado.Fechanacimiento;
                cmd.Parameters.Add("@fechaentrada", SqlDbType.DateTime).Value = empleado.Fechaentrada;
                //cmd.Parameters.Add("@contraseña", SqlDbType.VarChar, 10).Value = empleado.Contraseña;


                cmd.Parameters.Add("@idempleado", SqlDbType.SmallInt).Value = empleado.Idempleado;
           



                //---ejecutar el comando
                result = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //el flujo del codigo 
                //entra a este bloque si
                //es que hay una excepcion


                Logger log = new Logger();
                log.setException(ex);

                throw new Exception(ex.Message);


            }
            finally
            {
                //--flujo del codigo SIEMPRE 
                // para por este bloque
                con.Close();
            }

            return result;

        }

      ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        public Int32 M_eliminar_empleado(Int16 idEmpleado)
        {

            Int32 result = 0; // retorno de mi metodo insertar
            SqlConnection con = null; // para conectarme a mi BD.

            try
            {
                // apunta a la conexion de mi BD (direccion, BD, user,clave,)
                con = UConnection.getConnection();

                // abrimos la coneccion a la BD
                con.Open();

                // procedimiento almacenado para insertar cliente
                string sql = "sp_empleado_eliminar";

                // creamos un objeto comando para ejecutar el Procedimiento a.
                SqlCommand cmd = new SqlCommand(sql, con);

                //definir que estamos trabajando con procedimiento almacenados
                cmd.CommandType = CommandType.StoredProcedure;


                // pasar los parametros a mi procedimiento almacenado

                // parametros de entrada

                cmd.Parameters.Add("@idempleado", SqlDbType.SmallInt).Value = idEmpleado;


                //---ejecutar el comando
                result = cmd.ExecuteNonQuery();



            }
            catch (Exception ex)
            {
                //el flujo del codigo 
                //entra a este bloque si
                //es que hay una excepcion

                Logger log = new Logger();
                log.setException(ex);
                throw new Exception("Error al acceder a la BD");


            }
            finally
            {
                //--flujo del codigo SIEMPRE 
                // para por este bloque
                con.Close();
            }

            return result;

        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        public Empleado M_buscarPorId_empleado(Int16 idEmpleado)
        {
            Empleado empleado = new Empleado(); ; // retorno de mi metodo buscarPorEntidad
            SqlConnection con = null; // para conectarme a mi BD.
            try
            {
                con = UConnection.getConnection();
                con.Open();
                string sql = "sp_empleado_buscar_por_id";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@idempleado", SqlDbType.SmallInt).Value = idEmpleado;
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                { 
                    while (reader.Read())
                    {

                        

                        empleado.Idempleado = Convert.ToInt16(reader["idempleado"]);
                        empleado.Nombre = Convert.ToString(reader["nombree"]);
                        empleado.Direccion = Convert.ToString(reader["direccione"]);
                        empleado.Apellido = Convert.ToString(reader["apellidoe"]);
                        empleado.Cargo = Convert.ToString(reader["cargoe"]);
                        empleado.Telefono = Convert.ToString(reader["telefonoe"]);
                        empleado.Dni = Convert.ToString(reader["DNI"]);
                        empleado.Fechanacimiento = Convert.ToDateTime(reader["fechanacimiento"]);
                        empleado.Fechaentrada = Convert.ToDateTime(reader["fechaentrada"]);
                       // empleado.Contraseña = Convert.ToString(reader["contraseña"]);
                   
                    }
                }
            }
            catch (Exception ex)
            {
                //el flujo del codigo 
                //entra a este bloque si
                //es que hay una excepcion

                Logger log = new Logger();
                log.setException(ex);

                throw ;


            }
            finally
            {
                //--flujo del codigo SIEMPRE 
                // para por este bloque
                con.Close();
            }

            return empleado;

        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        public List<Empleado> M_buscarPorDNI_empleado(string dni)
        {

            List<Empleado> empleados = new List<Empleado>(); // retorno de mi metodo buscarPorEntidad
            SqlConnection con = null; // para conectarme a mi BD.

            try
            {
                con = UConnection.getConnection();
                con.Open();
                string sql = "sp_empleado_buscar_por_DNI";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@DNI", SqlDbType.VarChar, 8).Value = dni;
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Empleado empleado = new Empleado();
                        empleado.Idempleado = Convert.ToInt16(reader["idempleado"]);
                        empleado.Nombre = Convert.ToString(reader["nombree"]);
                        empleado.Apellido = Convert.ToString(reader["apellidoe"]);
                        empleado.Cargo = Convert.ToString(reader["cargoe"]);
                        empleados.Add(empleado);
                    }
                }
            }
            catch (Exception ex)
            {
                Logger log = new Logger();
                log.setException(ex);
                throw new Exception("Error al acceder a la BD");
            }
            finally
            {
                con.Close();
            }
            return empleados;
        }





        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public bool M_validar_empleado(Empleado empleado)
        {
            bool resp = false;
            SqlConnection con = null;
            try
            {                
                con = UConnection.getConnection();
                con.Open();
                string sql = "sp_empleado_validar_empleado";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.CommandText = "SELECT* FROM sp_empleado_validar_empleado WHERE user = @dni";
                
                cmd.Parameters.Add("@dni", SqlDbType.VarChar, 8).Value = empleado.Dni;
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {

                    string claveAlmacenada = "";
                    while (reader.Read())
                    {
                        empleado.Dni = Convert.ToString(reader["DNI"]);
                        empleado.Idempleado = Convert.ToInt16(reader["idempleado"]);
                        empleado.Nombre = Convert.ToString(reader["nombree"]);
                        empleado.Apellido = Convert.ToString(reader["apellidoe"]);
                        claveAlmacenada = Convert.ToString(reader["contrasenia"]);
                        empleado.Telefono = Convert.ToString(reader["telefonoe"]);                     
                        empleado.Fechanacimiento = Convert.ToDateTime(reader["fechanacimiento"]);
                        empleado.Fechaentrada = Convert.ToDateTime(reader["fechaentrada"]);
                        empleado.Direccion = Convert.ToString(reader["direccione"]);
                        empleado.Cargo = Convert.ToString(reader["cargoe"]);
                     }
                    resp = BCrypt.Net.BCrypt.Verify(empleado.Contraseña, claveAlmacenada);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
            return resp;
        }

        ////////////////////////////////////////////////////////////////




        public Empleado M_buscarDNIRepetido_empleado(string dni)
        {
            Empleado empleado = new Empleado(); ; // retorno de mi metodo buscarPorEntidad
            SqlConnection con = null; // para conectarme a mi BD.
            try
            {
                con = UConnection.getConnection();
                con.Open();
                string sql = "sp_empleado_buscar_dni_repetido";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@dniRepetido", SqlDbType.VarChar, 8).Value = dni;
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        empleado.Dni = Convert.ToString(reader["DNI"]);
                       
                    }
                }
            }
            catch (Exception ex)
            {
                //el flujo del codigo 
                //entra a este bloque si
                //es que hay una excepcion

                Logger log = new Logger();
                log.setException(ex);

                throw;


            }
            finally
            {
                //--flujo del codigo SIEMPRE 
                // para por este bloque
                con.Close();
            }

            return empleado;

        }


    }
}
