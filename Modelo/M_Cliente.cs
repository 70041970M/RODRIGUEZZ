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

//Aqui van los metodos
namespace Rodriguez.Modelo
{
    class M_Cliente
    {
       

        public Int32 M_insertar_cliente(Cliente cliente)
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
                string sql = "sp_cliente_insertar";

                // creamos un objeto comando para ejecutar el Procedimiento a.
                SqlCommand cmd = new SqlCommand(sql, con);

                //definir que estamos trabajando con procedimiento almacenados
                cmd.CommandType = CommandType.StoredProcedure;


                // pasar los parametros a mi procedimiento almacenado

                // parametros de entrada

                cmd.Parameters.Add("@DNIc", SqlDbType.VarChar, 8).Value = cliente.Dni;
                cmd.Parameters.Add("@nombrec", SqlDbType.VarChar, 50).Value = cliente.Nombre;
                cmd.Parameters.Add("@apellidoc", SqlDbType.VarChar, 50).Value = cliente.Apellido;
                cmd.Parameters.Add("@direccion", SqlDbType.VarChar, 100).Value = cliente.Direccion;
                cmd.Parameters.Add("@telefonoc", SqlDbType.VarChar, 20).Value = cliente.Telefono;
                cmd.Parameters.Add("@correoc", SqlDbType.VarChar, 100).Value = cliente.Correo;
                cmd.Parameters.Add("@ruc", SqlDbType.VarChar, 11).Value = cliente.Ruc;
                cmd.Parameters.Add("@razonsocial", SqlDbType.VarChar, 200).Value = cliente.Razonsocial;
             

                //--parametro de salida para obtener el id_cliente

                SqlParameter outParam = cmd.Parameters.Add("@idcliente", SqlDbType.SmallInt);
                outParam.Direction = ParameterDirection.Output;

                //---ejecutar el comando
                result = cmd.ExecuteNonQuery();


                // almacenando el valor de la clave primaria: id_cliente (identity)
                cliente.Idcliente= Convert.ToInt16(cmd.Parameters["@idcliente"].Value);




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


        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public Int32 M_actualizar_cliente(Cliente cliente)
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
                string sql = "sp_cliente_actualizar";

                // creamos un objeto comando para ejecutar el Procedimiento a.
                SqlCommand cmd = new SqlCommand(sql, con);

                //definir que estamos trabajando con procedimiento almacenados
                cmd.CommandType = CommandType.StoredProcedure;


                // pasar los parametros a mi procedimiento almacenado

                // parametros de entrada

                cmd.Parameters.Add("@DNIc", SqlDbType.VarChar, 8).Value = cliente.Dni;
                cmd.Parameters.Add("@nombrec", SqlDbType.VarChar, 50).Value = cliente.Nombre;
                cmd.Parameters.Add("@apellidoc", SqlDbType.VarChar, 50).Value = cliente.Apellido;
                cmd.Parameters.Add("@direccion", SqlDbType.VarChar, 100).Value = cliente.Direccion;
                cmd.Parameters.Add("@telefonoc", SqlDbType.VarChar, 20).Value = cliente.Telefono;
                cmd.Parameters.Add("@correoc", SqlDbType.VarChar, 100).Value = cliente.Correo;
                cmd.Parameters.Add("@ruc", SqlDbType.VarChar, 11).Value = cliente.Ruc;
                cmd.Parameters.Add("@razonsocial", SqlDbType.VarChar, 200).Value = cliente.Razonsocial;


                cmd.Parameters.Add("@idcliente", SqlDbType.SmallInt).Value = cliente.Idcliente;


           

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

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public Int32 M_eliminar_cliente(Int16 idCliente)
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
                string sql = "sp_cliente_eliminar";

                // creamos un objeto comando para ejecutar el Procedimiento a.
                SqlCommand cmd = new SqlCommand(sql, con);

                //definir que estamos trabajando con procedimiento almacenados
                cmd.CommandType = CommandType.StoredProcedure;


                // pasar los parametros a mi procedimiento almacenado

                // parametros de entrada

                cmd.Parameters.Add("@idcliente", SqlDbType.SmallInt).Value = idCliente;


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



                if (ex.Message.Contains("R_4"))
                {
                    throw new Exception("Este cliente no puede ser eliminado, por que esta registrado en una venta");
                }
                else
                {

                    throw;
                }

            }
            finally
            {
                //--flujo del codigo SIEMPRE 
                // para por este bloque
                con.Close();
            }

            return result;

        }
  //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        public Cliente M_buscarPorId_cliente(Int16 idCliente)
        {
            Cliente cliente = new Cliente(); ; // retorno de mi metodo buscarPorEntidad
            SqlConnection con = null; // para conectarme a mi BD.
            try
            {
                con = UConnection.getConnection();
                con.Open();
                string sql = "sp_cliente_buscar_por_id";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                
                cmd.Parameters.Add("@idcliente", SqlDbType.SmallInt).Value = idCliente;
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cliente.Idcliente = Convert.ToInt16(reader["idcliente"]);
                        cliente.Dni = Convert.ToString(reader["DNIc"]);
                        cliente.Nombre = Convert.ToString(reader["nombrec"]);
                        cliente.Apellido = Convert.ToString(reader["apellidoc"]);
                        cliente.Direccion = Convert.ToString(reader["direccion"]);
                        cliente.Telefono = Convert.ToString(reader["telefonoc"]);
                        cliente.Correo = Convert.ToString(reader["correoc"]);
                        cliente.Ruc = Convert.ToString(reader["ruc"]);
                        cliente.Razonsocial = Convert.ToString(reader["razonsocial"]);
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
            return cliente;
        }


  //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



        public List<Cliente> M_buscarPorDNI_cliente(string dni)
        {

            List<Cliente> clientes = new List<Cliente>(); // retorno de mi metodo buscarPorEntidad
            SqlConnection con = null; // para conectarme a mi BD.

            try
            {
                con = UConnection.getConnection();
                con.Open();
                string sql = "sp_cliente_buscar_por_DNI";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@DNIc", SqlDbType.VarChar, 8).Value = dni;
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Cliente cliente = new Cliente();

                        cliente.Idcliente = Convert.ToInt16(reader["idcliente"]);
                        cliente.Dni = Convert.ToString(reader["DNIc"]);
                        cliente.Nombre = Convert.ToString(reader["nombrec"]);
                        cliente.Apellido = Convert.ToString(reader["apellidoc"]);

                        clientes.Add(cliente);
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
            return clientes;
        }
        ///////////////////////////////////////////////////
        public List<Cliente> M_buscarPorRuc_cliente(string ruc)
        {

            List<Cliente> clientes = new List<Cliente>(); // retorno de mi metodo buscarPorEntidad
            SqlConnection con = null; // para conectarme a mi BD.

            try
            {
                con = UConnection.getConnection();
                con.Open();
                string sql = "sp_cliente_buscar_por_RUC";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ruc", SqlDbType.VarChar, 11).Value = ruc;
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Cliente cliente = new Cliente();

                        cliente.Idcliente = Convert.ToInt16(reader["idcliente"]);
                        cliente.Ruc = Convert.ToString(reader["ruc"]);
                        cliente.Razonsocial = Convert.ToString(reader["razonsocial"]);


                        clientes.Add(cliente);
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
            return clientes;
        }

        /////////////////////////////////////////////////////////



        public List<Cliente> M_Buscar_clienteNatural(DateTime fechaIni, DateTime fechaFin)
        {

            List<Cliente> clientes = new List<Cliente>(); // retorno de mi metodo buscarPorEntidad
            SqlConnection con = null; // para conectarme a mi BD.

            try
            {
                con = UConnection.getConnection();
                con.Open();
                string sql = "sp_cliente_listar_entre_fechas_natural";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@parFechaDeRegistroDesde", SqlDbType.DateTime).Value = fechaIni;
                cmd.Parameters.AddWithValue("@parFechaDeRegistroHasta", SqlDbType.DateTime).Value = fechaFin;
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Cliente cliente = new Cliente();
                        cliente.Idcliente = Convert.ToInt16(reader["idcliente"]);
                        cliente.Dni = Convert.ToString(reader["DNIc"]);
                        cliente.Nombre = Convert.ToString(reader["nombrec"]);
                        cliente.Apellido = Convert.ToString(reader["apellidoc"]);
                        cliente.Direccion = Convert.ToString(reader["direccion"]);
                        cliente.Telefono = Convert.ToString(reader["telefonoc"]);
                        clientes.Add(cliente);
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
            return clientes;
        }




        ////////////////////////////////////

        public List<Cliente> M_Buscar_clienteEmpresa(DateTime fechaIni, DateTime fechaFin)
        {

            List<Cliente> clientes = new List<Cliente>(); // retorno de mi metodo buscarPorEntidad
            SqlConnection con = null; // para conectarme a mi BD.

            try
            {
                con = UConnection.getConnection();
                con.Open();
                string sql = "sp_cliente_listar_entre_fechas_empresa";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@parFechaDeRegistroDesde", SqlDbType.DateTime).Value = fechaIni;
                cmd.Parameters.AddWithValue("@parFechaDeRegistroHasta", SqlDbType.DateTime).Value = fechaFin;
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Cliente cliente = new Cliente();
                        cliente.Idcliente = Convert.ToInt16(reader["idcliente"]);
                        cliente.Ruc = Convert.ToString(reader["ruc"]);
                        cliente.Razonsocial = Convert.ToString(reader["razonsocial"]);
                        cliente.Direccion = Convert.ToString(reader["direccion"]);
                        cliente.Telefono = Convert.ToString(reader["telefonoc"]);
                        cliente.Correo = Convert.ToString(reader["correoc"]);
                        clientes.Add(cliente);
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
            return clientes;
        }


        ////////////////////////////////////


        //public Cliente buscarPorDNIRepetido(string dni)
        //{
        //    Cliente cliente = new Cliente(); ; // retorno de mi metodo buscarPorEntidad
        //    SqlConnection con = null; // para conectarme a mi BD.
        //    try
        //    {
        //        con = UConnection.getConnection();
        //        con.Open();
        //        string sql = "sp_cliente_buscar_por_id";
        //        SqlCommand cmd = new SqlCommand(sql, con);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.Add("@idcliente", SqlDbType.SmallInt).Value = idCliente;
        //        SqlDataReader reader = cmd.ExecuteReader();
        //        if (reader.HasRows)
        //        {
        //            while (reader.Read())
        //            {
        //                cliente.Idcliente = Convert.ToInt16(reader["idcliente"]);
        //                cliente.Dni = Convert.ToString(reader["DNIc"]);
        //                cliente.Nombre = Convert.ToString(reader["nombrec"]);
        //                cliente.Apellido = Convert.ToString(reader["apellidoc"]);
        //                cliente.Direccion = Convert.ToString(reader["direccion"]);
        //                cliente.Telefono = Convert.ToString(reader["telefonoc"]);
        //                cliente.Correo = Convert.ToString(reader["correoc"]);
        //                cliente.Ruc = Convert.ToString(reader["ruc"]);
        //                cliente.Razonsocial = Convert.ToString(reader["razonsocial"]);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Logger log = new Logger();
        //        log.setException(ex);
        //        throw new Exception("Error al acceder a la BD");
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
        //    return cliente;
        //}







    }
}
