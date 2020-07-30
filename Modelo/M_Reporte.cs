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
    class M_Reporte
    {
       
        public  frodriguezDataSet1 M_listar_ClientesEmpresa(DateTime fechaIni, DateTime fechaFin)
        {
             
            SqlConnection con = null; // para conectarme a mi BD.
            SqlDataAdapter adapter = new SqlDataAdapter();
            frodriguezDataSet1 ds =new frodriguezDataSet1();
            try
            {
                con = UConnection.getConnection();
                con.Open();
                string sql = @"
                             SELECT 
                             cliente.idcliente as id,
                             cliente.ruc as ruc, 
                             cliente.razonsocial as razonsocial, 
                             cliente.direccion as direccion, 
                             cliente.telefonoc as telefono, 
                             cliente.correoc as correo
                             from [dbo].[cliente] inner join [dbo].[venta]  on cliente.idcliente = venta.idcliente

                             WHERE fechaventa BETWEEN @fechaini AND @fechafin  and ruc <> ''
                             GROUP BY  cliente.idcliente,ruc, razonsocial, direccion, telefonoc, correoc


                                            ";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@fechaini", SqlDbType.DateTime).Value = fechaIni;
                cmd.Parameters.Add("@fechafin", SqlDbType.DateTime).Value = fechaFin;
                adapter.SelectCommand = cmd;
                adapter.Fill(ds, "reporteClientesEmpresa");


                 
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
            return ds;
        }
        //////////////////////////////////////////////




        public frodriguezDataSet1 M_listar_ClientesNatural(DateTime fechaIni, DateTime fechaFin)
        {

            SqlConnection con = null; // para conectarme a mi BD.
            SqlDataAdapter adapter = new SqlDataAdapter();
            frodriguezDataSet1 ds = new frodriguezDataSet1();
            try
            {
                con = UConnection.getConnection();
                con.Open();
                string sql = @"
                             Select
                                cliente.idcliente as id,
                                cliente.DNIc as dni,
                                cliente.nombrec as nombre,
                                cliente.apellidoc as apellidos,
                                cliente.direccion as direccion,
                                cliente.telefonoc as telefono
                                  from [dbo].[cliente]  inner join [dbo].[venta] on cliente.idcliente = venta.idcliente

                                WHERE venta.fechaventa BETWEEN @fechaIni AND @fechaFin  and cliente.DNIc <> ''
                                GROUP BY cliente.idcliente, cliente.DNIc, cliente.nombrec, cliente.apellidoc, cliente.direccion, cliente.telefonoc, cliente.correoc




                                            ";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@fechaini", SqlDbType.DateTime).Value = fechaIni;
                cmd.Parameters.Add("@fechafin", SqlDbType.DateTime).Value = fechaFin;
                adapter.SelectCommand = cmd;
                adapter.Fill(ds, "reporteClientesNatural");



            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
            return ds;
        }
        //////////////////////////////////////////////


        public frodriguezDataSet1 M_Top_ProductosPorFechas(DateTime fechaIni, DateTime fechaFin)
        {

            SqlConnection con = null; // para conectarme a mi BD.
            SqlDataAdapter adapter = new SqlDataAdapter();
            frodriguezDataSet1 ds = new frodriguezDataSet1();
            try
            {
                con = UConnection.getConnection();
                con.Open();
                string sql = @"
                          
                             SELECT top 10 
							 producto.idproducto as id,
                             producto.nombrepro as nombre, 
                             producto.diseño as diseño,
                             producto.material as material,
                             producto.categoriapro as categoria,
                             producto.color as color,
                             sum(ventadetalle.cantidad)as cantidad 
                             FROM   [dbo].[producto]  INNER JOIN [dbo].[ventadetalle] 
                             ON ventadetalle.idproducto= producto.idproducto
							 inner join venta v on v.idventa = ventadetalle.idventa

							 WHERE v.fechaventa BETWEEN @fechaIni AND @fechaFin
                             group by producto.idproducto,producto.nombrepro,producto.diseño,producto.material,producto.categoriapro,producto.color 
         
                             ORDER BY cantidad  DESC      
                                            ";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@fechaini", SqlDbType.DateTime).Value = fechaIni;
                cmd.Parameters.Add("@fechafin", SqlDbType.DateTime).Value = fechaFin;
                adapter.SelectCommand = cmd;
                adapter.Fill(ds, "reporteTopProductos");

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
            return ds;
        }


        ////////////////////////////////////////////
        public frodriguezDataSet1 M_listar_Productos()
        {
            SqlConnection con = null; // para conectarme a mi BD.
            SqlDataAdapter adapter = new SqlDataAdapter();
            frodriguezDataSet1 ds = new frodriguezDataSet1();
            try
            {
                con = UConnection.getConnection();
                con.Open();
                string sql = @"
                            select
                            producto.idproducto as idproducto , 
                            producto.nombrepro as nombrepro, 
                            producto.diseño as diseño, 
                            producto.material as material, 
                            producto.descripcion as descripcion, 
                            producto.precio as precio , 
                            producto.tamaño as tamaño,
                            producto.stockpro as stock
                            FROM
                            [dbo].[producto] 
                            ORDER BY stockpro               
                                            ";
                SqlCommand cmd = new SqlCommand(sql, con);
                adapter.SelectCommand = cmd;
                adapter.Fill(ds, "reporteProductos");

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
            return ds;
        }

        ////////////////////////////////////////////


        public frodriguezDataSet1 M_listar_Empleados()
        {
            SqlConnection con = null; // para conectarme a mi BD.
            SqlDataAdapter adapter = new SqlDataAdapter();
            frodriguezDataSet1 ds = new frodriguezDataSet1();
            try
            {
                con = UConnection.getConnection();
                con.Open();
                string sql = @"
                            select
                                empleado.idempleado as idempleado, 
                                empleado.nombree as nombree, 
                                empleado.apellidoe as apellidoe, 
                                empleado.direccione as direccione , 
                                empleado.cargoe as cargoe, 
                                empleado.telefonoe as telefonoe, 
                                empleado.DNI as DNI, 
                                empleado.fechanacimiento as fechanacimiento, 
                                empleado.fechaentrada as fechaentrada                                
                                from [dbo].[empleado]  
                                             
                                            ";
                SqlCommand cmd = new SqlCommand(sql, con);
                adapter.SelectCommand = cmd;
                adapter.Fill(ds, "reporteEmpleado");

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
            return ds;
        }

///////////////////////////////////////////////////////////////////////////////////////////////////////////////


        public frodriguezDataSet1 M_listar_ProductosStock()
        {
            SqlConnection con = null; // para conectarme a mi BD.
            SqlDataAdapter adapter = new SqlDataAdapter();
            frodriguezDataSet1 ds = new frodriguezDataSet1();
            try
            {
                con = UConnection.getConnection();
                con.Open();
                string sql = @"
                             SELECT categoriapro,
                                 nombrepro, 
                                 stockpro,
                                  diseño,
                                  material,
                                  tamaño 
                                  FROM [dbo].[producto]
                                where stockpro <=5
                             ";
                SqlCommand cmd = new SqlCommand(sql, con);
                adapter.SelectCommand = cmd;
                adapter.Fill(ds, "reporteStockProductos");

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
            return ds;
        }
        
        
        
/////////////////////////////////////////////////////////////////////////////////////////


        public frodriguezDataSet1 M_reporte_Factura(int idVenta)
        {


            SqlConnection con = null;


            SqlDataAdapter adapter = new SqlDataAdapter();
            frodriguezDataSet1 ds = new frodriguezDataSet1();

            try
            {

                con = UConnection.getConnection();

                con.Open();

                // string sql = "sp_usuario_insertar";
                string sql;


                sql = @"
                        SELECT
                        venta.idventa as id_venta
                        ,CASE WHEN venta.tipo_comprobante='F'
                        THEN 'FACTURA ELECTRONICA'
                        ELSE 'BOLETA ELECTRONICA'
                        END as tipo_comprobante
                        ,venta.tipo_comprobante +venta.serie+'-'+venta.numero as comprobante
                        ,venta.fechaventa as fecha
                        ,cliente.razonsocial as nombrec
                        ,cliente.direccion as direccion
                        ,cliente.ruc as ruc
                        ,ventadetalle.cantidad as cantidad
                        ,producto.nombrepro as nombrepro
                        ,ventadetalle.preciounit as precio_unitario
                        ,ventadetalle.preciounit*ventadetalle.cantidad  as valor_venta
                        ,auxiliar.total as total
                        ,auxiliar.total*venta.igv as igv
                        ,auxiliar.total-auxiliar.total*venta.igv as subtotal
                        FROM
                        venta
                        INNER JOIN cliente ON venta.idcliente= cliente.idcliente
                        INNER JOIN ventadetalle ON venta.idventa= ventadetalle.idventa
                        INNER JOIN producto ON ventadetalle.idproducto= producto.idproducto
                        INNER JOIN (
                        SELECT
                        venta.idventa as id_venta
                        ,isnull(SUM(ventadetalle.preciounit*ventadetalle.cantidad),0) as total
                        FROM
                        venta
                        INNER JOIN ventadetalle ON venta.idventa= ventadetalle.idventa
                        WHERE
                        venta.idventa=@idVenta
                        GROUP BY
                        venta.idventa
                        ) as auxiliar
                        ON venta.idventa=auxiliar.id_venta
                        WHERE
                        venta.idventa=@idVenta

";
                SqlCommand cmd = new SqlCommand(sql, con);

                // cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@idVenta", SqlDbType.Int).Value = idVenta;
                
                adapter.SelectCommand = cmd;

                //---- nombre del datatable-----------
                adapter.Fill(ds, "reporteFactura");





            }
            catch (Exception)
            {
                throw;

            }
            finally
            {

                con.Close();
            }

            return ds;
        }

        //-------------------------------------------------------------------------------------------



        public frodriguezDataSet1 M_reporte_Boleta(int idVenta)
        {
            SqlConnection con = null;
            SqlDataAdapter adapter = new SqlDataAdapter();
            frodriguezDataSet1 ds = new frodriguezDataSet1();
            try
            {
                con = UConnection.getConnection();
                con.Open();
                // string sql = "sp_usuario_insertar";
                string sql;
                sql = @"
                       SELECT
                        venta.idventa as id_venta
                        ,CASE WHEN venta.tipo_comprobante='B'
                        THEN 'BOLETA ELECTRONICA'
                        ELSE 'FACTURA ELECTRONICA'
                        END as tipo_comprobante
                        ,venta.tipo_comprobante +venta.serie+'-'+venta.numero as comprobante
                        ,venta.fechaventa as fecha
                        , concat (cliente.nombrec,' ', cliente.apellidoc) as nombrec
                        ,cliente.direccion as direccion
                        ,ventadetalle.cantidad as cantidad
                        ,producto.nombrepro as nombrepro
                        ,ventadetalle.preciounit as precio_unitario
                        ,ventadetalle.preciounit*ventadetalle.cantidad  as valor_venta
                        ,auxiliar.total as total
                        --,auxiliar.total*venta.igv as igv
                        --,auxiliar.total-auxiliar.total*venta.igv as subtotal
                        FROM
                        [dbo].[venta]
                        INNER JOIN cliente ON venta.idcliente= cliente.idcliente
                        INNER JOIN ventadetalle ON venta.idventa= ventadetalle.idventa
                        INNER JOIN producto ON ventadetalle.idproducto= producto.idproducto
                        INNER JOIN 
						
						(
                        SELECT
                        venta.idventa as id_venta
                        ,isnull(SUM(ventadetalle.preciounit*ventadetalle.cantidad),0) as total
                        FROM
                        venta
                        INNER JOIN ventadetalle ON venta.idventa= ventadetalle.idventa
                        WHERE
                        venta.idventa=@idVenta
                        GROUP BY
                        venta.idventa
                        ) as auxiliar
                        ON venta.idventa=auxiliar.id_venta
                        WHERE
                        venta.idventa=@idVenta
                        ";
                SqlCommand cmd = new SqlCommand(sql, con);
                // cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@idVenta", SqlDbType.Int).Value = idVenta;

                adapter.SelectCommand = cmd;

                //---- nombre del datatable-----------
                adapter.Fill(ds, "reporteBoleta");
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
            return ds;
        }


        ///////////////////////////////////////////////////////////////////////////////



    }
}
