using Datos.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class cAlmacen
    {
        public cAlmacen() { }

        public List<Almacen> Listar()
        {
            List<Almacen> Lista = new List<Almacen>();
            using (SqlConnection conexion = ConexionBD.obtenerConexion())
            {
                string query = "select * from Almacen";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Almacen almacen = new Almacen();
                    almacen.codAlmacen = reader.GetInt32(0);
                    almacen.nombreAlmacen = reader.GetString(1);
                    Lista.Add(almacen);
                }
                conexion.Close();
            }

            return Lista;
        }
    }
}
