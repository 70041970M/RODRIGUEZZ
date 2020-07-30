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

namespace Rodriguez.Modelo
{
    class M_Producto
    {
        public Int32 M_registrar_Producto(Producto producto)
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
                string sql = "sp_producto_insertar";

                // creamos un objeto comando para ejecutar el Procedimiento a.
                SqlCommand cmd = new SqlCommand(sql, con);

                //definir que estamos trabajando con procedimiento almacenados
                cmd.CommandType = CommandType.StoredProcedure;


                // pasar los parametros a mi procedimiento almacenado

                // parametros de entrada

                cmd.Parameters.Add("@stockpro", SqlDbType.Int).Value = producto.Stock;
                cmd.Parameters.Add("@categoriapro", SqlDbType.VarChar, 20).Value = producto.Categoria;
                cmd.Parameters.Add("@color", SqlDbType.VarChar, 20).Value = producto.Color;
                cmd.Parameters.Add("@nombrepro", SqlDbType.VarChar, 50).Value = producto.Nombre;
                cmd.Parameters.Add("@diseño", SqlDbType.VarChar, 50).Value = producto.Diseño;
                cmd.Parameters.Add("@material", SqlDbType.VarChar, 100).Value = producto.Material;
                cmd.Parameters.Add("@descripcion", SqlDbType.VarChar, 150).Value = producto.Descripcion;
                cmd.Parameters.Add("@precio", SqlDbType.Decimal).Value = producto.Precio;
                // milah dice que habra errorrrr aqui
                cmd.Parameters.Add("@tamaño", SqlDbType.VarChar, 20).Value = producto.Tamaño;


                //--parametro de salida para obtener el id_cliente

                SqlParameter outParam = cmd.Parameters.Add("@idproducto", SqlDbType.SmallInt);
                outParam.Direction = ParameterDirection.Output;

                //---ejecutar el comando
                result = cmd.ExecuteNonQuery();


                // almacenando el valor de la clave primaria: id_cliente (identity)
                producto.Idproducto = Convert.ToInt16(cmd.Parameters["@idproducto"].Value);




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

        /////////////////////////////////////

        public Int32 M_actualizar_Producto(Producto producto)
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
                string sql = "sp_producto_actualizar";

                // creamos un objeto comando para ejecutar el Procedimiento a.
                SqlCommand cmd = new SqlCommand(sql, con);

                //definir que estamos trabajando con procedimiento almacenados
                cmd.CommandType = CommandType.StoredProcedure;


                // pasar los parametros a mi procedimiento almacenado

                // parametros de entrada


                cmd.Parameters.Add("@stockpro", SqlDbType.Int).Value = producto.Stock;
                cmd.Parameters.Add("@nombrepro", SqlDbType.VarChar, 50).Value = producto.Nombre;
                cmd.Parameters.Add("@diseño", SqlDbType.VarChar, 50).Value = producto.Diseño;
                cmd.Parameters.Add("@material", SqlDbType.VarChar, 100).Value = producto.Material;
                cmd.Parameters.Add("@descripcion", SqlDbType.VarChar, 150).Value = producto.Descripcion;
                cmd.Parameters.Add("@precio", SqlDbType.Decimal).Value = producto.Precio;
                cmd.Parameters.Add("@tamaño", SqlDbType.VarChar, 20).Value = producto.Tamaño;
                cmd.Parameters.Add("@categoriapro", SqlDbType.VarChar, 20).Value = producto.Categoria;
                cmd.Parameters.Add("@color", SqlDbType.VarChar, 20).Value = producto.Categoria;
                cmd.Parameters.Add("@idproducto", SqlDbType.SmallInt).Value = producto.Idproducto;



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

        ///////////////////////////////////////////////
        public Int32 M_Eliminar_Producto(Int16 idProducto)
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
                string sql = "sp_producto_eliminar";

                // creamos un objeto comando para ejecutar el Procedimiento a.
                SqlCommand cmd = new SqlCommand(sql, con);

                //definir que estamos trabajando con procedimiento almacenados
                cmd.CommandType = CommandType.StoredProcedure;


                // pasar los parametros a mi procedimiento almacenado

                // parametros de entrada

                cmd.Parameters.Add("@idproducto", SqlDbType.SmallInt).Value = idProducto;


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
                //throw new Exception("Error al acceder a la BD");
                if (ex.Message.Contains("R_6"))
                {
                    throw new Exception("Este producto no puede ser elimindano, por que esta registrado en una venta");
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
        /////////////////////////////////////////
        public Producto M_BuscarPorId_Producto(Int16 idProducto)
        {

            Producto producto = new Producto(); ; // retorno de mi metodo buscarPorEntidad
            SqlConnection con = null; // para conectarme a mi BD.

            try
            {
                // apunta a la conexion de mi BD (direccion, BD, user,clave,)
                con = UConnection.getConnection();

                // abrimos la coneccion a la BD
                con.Open();

                // procedimiento almacenado para insertar cliente
                string sql = "sp_producto_buscar_por_id";

                // creamos un objeto comando para ejecutar el Procedimiento a.
                SqlCommand cmd = new SqlCommand(sql, con);

                //definir que estamos trabajando con procedimiento almacenados
                cmd.CommandType = CommandType.StoredProcedure;


                // pasar los parametros a mi procedimiento almacenado

                // parametros de entrada

                cmd.Parameters.Add("@idproducto", SqlDbType.SmallInt).Value = idProducto;



                //---ejecutamos el comando y leemos los registros
                //para los select
                SqlDataReader reader = cmd.ExecuteReader();

                //preguntamos si tiene registros
                if (reader.HasRows)
                {

                    // leemos el lector
                    //mientras haya registros
                    while (reader.Read())
                    {



                        producto.Idproducto = Convert.ToInt16(reader["idproducto"]);
                        producto.Stock = Convert.ToInt16(reader["stockpro"]);
                        producto.Nombre = Convert.ToString(reader["nombrepro"]);
                        producto.Diseño = Convert.ToString(reader["diseño"]);
                        producto.Material = Convert.ToString(reader["material"]);
                        producto.Descripcion = Convert.ToString(reader["descripcion"]);
                        producto.Precio = Convert.ToDecimal(reader["precio"]);
                        producto.Tamaño = Convert.ToString(reader["tamaño"]);
                        producto.Categoria = Convert.ToString(reader["categoriapro"]);
                        producto.Color = Convert.ToString(reader["color"]);





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

                throw new Exception("Error al acceder a la BD");


            }
            finally
            {
                //--flujo del codigo SIEMPRE 
                // para por este bloque
                con.Close();
            }

            return producto;

        }



        public List<Producto> M_ListaTopProductos_Fechas(DateTime fechaIni, DateTime fechaFin)
        {

            List<Producto> productos = new List<Producto>(); // retorno de mi metodo buscarPorEntidad
            SqlConnection con = null; // para conectarme a mi BD.

            try
            {
                con = UConnection.getConnection();
                con.Open();
                string sql = "sp_producto_top_entre_fechas";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@parFechaDeRegistroDesde", SqlDbType.DateTime).Value = fechaIni;
                cmd.Parameters.AddWithValue("@parFechaDeRegistroHasta", SqlDbType.DateTime).Value = fechaFin;
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Producto producto = new Producto();
                        producto.Idproducto = Convert.ToInt16(reader["idproducto"]);
                        producto.Nombre = Convert.ToString(reader["nombrepro"]);
                        producto.Diseño = Convert.ToString(reader["diseño"]);
                        producto.Material = Convert.ToString(reader["material"]);
                        producto.Categoria = Convert.ToString(reader["categoriapro"]);
                        producto.Color = Convert.ToString(reader["color"]);
                        producto.Cantidad = Convert.ToInt32(reader["cantidad"]);
                        productos.Add(producto);
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
            return productos;
        }

        //////////////////////////////////////////////////////////////////////////////


        public List<Producto> M_BuscarPorNombre_Producto(string nombre)
        {

            List<Producto> productos = new List<Producto>(); // retorno de mi metodo buscarPorEntidad
            SqlConnection con = null; // para conectarme a mi BD.

            try
            {
                // apunta a la conexion de mi BD (direccion, BD, user,clave,)
                con = UConnection.getConnection();

                // abrimos la coneccion a la BD
                con.Open();

                // procedimiento almacenado para insertar cliente
                string sql = "sp_producto_buscar_por_nombre";

                // creamos un objeto comando para ejecutar el Procedimiento a.
                SqlCommand cmd = new SqlCommand(sql, con);

                //definir que estamos trabajando con procedimiento almacenados
                cmd.CommandType = CommandType.StoredProcedure;


                // pasar los parametros a mi procedimiento almacenado

                // parametros de entrada

                cmd.Parameters.Add("@nombrepro", SqlDbType.VarChar, 50).Value = nombre;



                //---ejecutamos el comando y leemos los registros
                //para los select
                SqlDataReader reader = cmd.ExecuteReader();

                //preguntamos si tiene registros
                if (reader.HasRows)
                {

                    // leemos el lector
                    //mientras haya registros
                    while (reader.Read())
                    {

                        Producto producto = new Producto();

                        producto.Idproducto = Convert.ToInt16(reader["idproducto"]);
                        producto.Stock = Convert.ToInt16(reader["stockpro"]);
                        producto.Nombre = Convert.ToString(reader["nombrepro"]);
                        producto.Diseño = Convert.ToString(reader["diseño"]);
                        producto.Material = Convert.ToString(reader["material"]);
                        producto.Precio = Convert.ToDecimal(reader["precio"]);
                        producto.Categoria = Convert.ToString(reader["categoriapro"]);
                        producto.Color = Convert.ToString(reader["color"]);
                        producto.Stock = Convert.ToInt16(reader["stockpro"]);
                        producto.Tamaño = Convert.ToString(reader["tamaño"]);
                  
                        // agregar al objetos clientes
                        // cada objeto cliente
                        productos.Add(producto);

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
                throw new Exception("Error al acceder a la BD");


            }
            finally
            {
                //--flujo del codigo SIEMPRE 
                // para por este bloque
                con.Close();
            }

            return productos;

        }
    }
}
