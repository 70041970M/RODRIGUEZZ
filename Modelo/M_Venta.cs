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
    class M_Venta
    {

        public Venta M_generarSerie_NumeroComprobante(string tipoComprobante)
        {

            Venta venta = new Venta(); 
            SqlConnection con = null;

            try
            {
                con = UConnection.getConnection();
                con.Open();
                string sql = "sp_venta_generar_serie_numero_comprobante";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@tipo_comprobante", SqlDbType.Char,1).Value = tipoComprobante;

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int serie = Convert.ToInt32(reader["maximo_numero"]);
                        int numero = Convert.ToInt32(reader["maximo_serie"]);

                        //verificar el valor de numero

                        if (numero == 0)
                        {
                            //el primer comprobante
                            serie = 1;
                            numero = 1;
                        }
                        else if (numero > 999999)
                        {
                            //se reinicia el numero a 1 y la serie aumenta en 1
                            numero = 1;
                            serie++;
                        }
                        else 
                        {
                            numero++;
                        }

                        //--Transformamos la serie y nuemro a cadena, con sus ceros a la izquierda

                        int longitudSerie = 4;
                        int longitudNumero = 6;

                        string digitosCerosSerie = new String('0', longitudSerie - serie.ToString().Length);
                        venta.Serie = digitosCerosSerie + serie.ToString();
                        

                        string digitosCerosNumero = new String('0', longitudNumero - numero.ToString().Length);
                        venta.Numero = digitosCerosNumero + numero.ToString();
                    }
                  }
                }

            
            catch (Exception )
            {
                throw;
            }
            finally
            {
                con.Close();
            }

            return venta;

        }



        public Int32 M_insertar_venta(Venta venta)
        {

            Int32 resp = 0;

            SqlTransaction objTransac = null;

            SqlConnection con = null;

            SqlCommand cmd1;
            SqlCommand cmd2;


            try
            {

                con = UConnection.getConnection();
                con.Open();

                
                //------ insertar cabezera (tabla venta)----

                string sql = "sp_venta_insertar";

                cmd1 = new SqlCommand(sql, con);
                cmd1.CommandType = CommandType.StoredProcedure;

                

              //  cmd1.Parameters.Add("@detalles", SqlDbType.VarChar, 150).Value = venta.Detalle;
                cmd1.Parameters.Add("@fechaventa", SqlDbType.Date).Value = venta.FechaVenta;
                cmd1.Parameters.Add("@idcliente", SqlDbType.SmallInt).Value = venta.Cliente.Idcliente;
                cmd1.Parameters.Add("@idempleado", SqlDbType.SmallInt).Value = EmpleadoLogueado.idempleado;
                cmd1.Parameters.Add("@serie", SqlDbType.VarChar, 6).Value = venta.Serie;
                cmd1.Parameters.Add("@numero", SqlDbType.VarChar, 6).Value = venta.Numero;
                cmd1.Parameters.Add("@tipo_comprobante", SqlDbType.Char, 1).Value = venta.TipoComprobante;
                cmd1.Parameters.Add("@igv", SqlDbType.Decimal).Value = venta.Igv;



              

                SqlParameter outParam = cmd1.Parameters.Add("@idventa", SqlDbType.SmallInt);
                outParam.Direction = ParameterDirection.Output;

                //----- insertar detalle (tabla venta_detalle)----------

                string sql2 = "sp_venta_detalle_insertar2";

                cmd2 = new SqlCommand(sql2, con);
                cmd2.CommandType = CommandType.StoredProcedure;


                cmd2.Parameters.Add(new SqlParameter("@idventa", SqlDbType.Int));
                cmd2.Parameters.Add(new SqlParameter("@idproducto", SqlDbType.Int));
                //cmd2.Parameters.Add(new SqlParameter("@idservicio", SqlDbType.Int));
                cmd2.Parameters.Add(new SqlParameter("@cantidad", SqlDbType.Int));
                cmd2.Parameters.Add(new SqlParameter("@preciounit", SqlDbType.Decimal));
             //   cmd2.Parameters.Add(new SqlParameter("@fechaentrega", SqlDbType.DateTime));
             //   cmd2.Parameters.Add(new SqlParameter("@observaciones", SqlDbType.VarChar, 150));

                //---- preparamos la transaccion-------


                objTransac = con.BeginTransaction();

                cmd1.Transaction = objTransac;
                cmd2.Transaction = objTransac;

                //----- ejecutar el 1er comando (cabezera) ----

                cmd1.ExecuteNonQuery();

              
         

                //---- leemos el id_venta generado( identity)

                venta.IdVenta = Convert.ToInt32(cmd1.Parameters["@idventa"].Value);


                // MessageBox.Show(venta.IdVenta.ToString());


                //------- ejecutamos el 2do comando (detalle)


              

                foreach (VentaDetalle item in venta.VentaDetalles)
                {

                    cmd2.Parameters["@idventa"].Value = venta.IdVenta;
                    cmd2.Parameters["@idproducto"].Value = item.Producto.Idproducto;
                    cmd2.Parameters["@cantidad"].Value = item.Cantidad;
                    cmd2.Parameters["@preciounit"].Value = item.PrecioUnitario;
                  //  cmd2.Parameters["@fechaentrega"].Value = item.FechaEntrega;
                 //   cmd2.Parameters["@observaciones"].Value = item.Observaciones;


                 
                    cmd2.ExecuteNonQuery();

                }


                //--- las operaciones se grabaran recien en esta instruccion
                objTransac.Commit();


            }
            catch (Exception ex)
            {


                objTransac.Rollback();

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



            return resp;
        }



        ////////////////////////////////////
        public List<Venta> M_BoletaBuscar_PorNombreCliente(string nombre)
        {

            List<Venta> ventas = new List<Venta>(); // retorno de mi metodo buscarPorEntidad
            SqlConnection con = null; // para conectarme a mi BD.

            try{

                con = UConnection.getConnection();
                con.Open();
                string sql = "sp_boleta_buscar_por_nombre_cliente";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", SqlDbType.DateTime).Value = nombre;
               
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Venta venta = new Venta();
                        venta.IdVenta = Convert.ToInt16(reader["idventa"]);
                        venta.Comprobante = Convert.ToString(reader["comprobante"]);

                        //venta.Cliente.Idcliente = Convert.ToInt16(reader["idcliente"]);

                        venta.FechaVenta = Convert.ToDateTime(reader["fechaventa"]);
                        //venta.Telefono = Convert.ToString(reader["telefonoc"]);
                        //venta.Correo = Convert.ToString(reader["correoc"]);
                        ventas.Add(venta);
                    }
                }
            }
            catch (Exception ex)
            {
                Logger log = new Logger();
                log.setException(ex);
                throw new Exception();
            }
            finally
            {
                con.Close();
            }
            return ventas;
        }


        ////////////////////////////////////
        public List<Venta> M_FacturaBuscar_PorRazonSocial(string razonsocial)
        {

            List<Venta> ventas = new List<Venta>(); // retorno de mi metodo buscarPorEntidad
            SqlConnection con = null; // para conectarme a mi BD.

            try
            {

                con = UConnection.getConnection();
                con.Open();
                string sql = "sp_factura_buscar_por_razon_social";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@razonsocial", SqlDbType.DateTime).Value = razonsocial;

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Venta venta = new Venta();
                        venta.IdVenta = Convert.ToInt16(reader["idventa"]);
                        venta.Comprobante = Convert.ToString(reader["comprobante"]);
                        //venta.Cliente.Idcliente = Convert.ToInt16(reader["idcliente"]);
                        venta.FechaVenta = Convert.ToDateTime(reader["fechaventa"]);
                        //venta.Cliente.Ruc = Convert.ToString(reader["ruc"]);
                        //venta.Cliente.Razonsocial = Convert.ToString(reader["razonsocial"]);
                        ventas.Add(venta);
                    }
                }
            }
            catch (Exception ex)
            {
                Logger log = new Logger();
                log.setException(ex);
                throw new Exception();
            }
            finally
            {
                con.Close();
            }
            return ventas;
        }


    }
}
