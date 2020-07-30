using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Rodriguez.Connection
{
    class UConnection
    {
        private static SqlConnection con = null;

        public static SqlConnection getConnection()
        {

            try
            {
                if (con == null)
                {
                    //AQUI FALTA AGREGAR LA CONECCION CON EL SQL
                    con = new SqlConnection(ConfigurationManager.ConnectionStrings["Rodriguez.Properties.Settings.frodriguezConnectionString"].ToString());

                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            return con;

        }
    }
}
