using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Models
{
    public class cCliente
    {
        public Cliente Buscar(int codigo)
        {
            List<Cliente> lstClientes = new List<Cliente>();
            Cliente cliente = new Cliente();

            using (SqlConnection conexion = ConexionBD.obtenerConexion())
            {
                string query = $"select * from Cliente where codCliente = {codigo}";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    cliente = new Cliente();
                    cliente.codCliente = reader.GetInt32(0);
                    cliente.snombreCliente = reader.GetString(1);
                    cliente.objGrupocliente = new GrupoCliente();
                    cliente.objGrupocliente.CodGrupoCliente = reader.GetInt32(2);

                    lstClientes.Add(cliente);
                }
                conexion.Close();
            }

            return lstClientes[0];
        }

    }
}
