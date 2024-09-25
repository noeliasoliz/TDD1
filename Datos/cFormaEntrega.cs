using Datos.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class cFormaEntrega
    {
        public cFormaEntrega() { }

        public List<FormaEntrega> Listar()
        {
            List<FormaEntrega> Lista = new List<FormaEntrega>();
            using (SqlConnection conexion = ConexionBD.obtenerConexion())
            {
                string query = "select * from FormaEntrega";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    FormaEntrega FormaEntrega = new FormaEntrega();
                    FormaEntrega.codFormaEntrega = reader.GetInt32(0);
                    FormaEntrega.nombreFormaEntrega = reader.GetString(1);
                    Lista.Add(FormaEntrega);
                }
                conexion.Close();
            }

            return Lista;
        }
    }
}
