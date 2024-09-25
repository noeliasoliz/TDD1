using Datos.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class cFormaPago
    {
        public cFormaPago() { }

        public List<FormaPago> Listar()
        {
            List<FormaPago> Lista = new List<FormaPago>();
            using (SqlConnection conexion = ConexionBD.obtenerConexion()) 
            {
                string query = "select * from FormaPago";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    FormaPago formaPago = new FormaPago();
                    formaPago.codFormaPago = reader.GetInt32(0);
                    formaPago.nombreFormaPago = reader.GetString(1);
                    Lista.Add(formaPago);
                }
                conexion.Close();
            }

            return Lista;
        }


    }
}
