using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Datos
{
    public class ConexionBD
    {
        string cadena = "Persist Security Info=False;User ID=sa;Initial Catalog=bd_practico2;Data Source=.";
        public SqlConnection conectarbd = new SqlConnection();

        public ConexionBD()
        {
            conectarbd.ConnectionString = cadena;
        }

        public void OpenConnection()
        {
            try
            {
                conectarbd.Open();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void CloseConnection()
        {
            conectarbd.Close();
        }

        public static SqlConnection obtenerConexion()
        {
            SqlConnection conexion = new SqlConnection("Persist Security Info=False;User ID=sa;Password=dualbiz123.;Initial Catalog=bd_practico2;Data Source=.");
            conexion.Open();
            return conexion;
        }
        
    }
}
