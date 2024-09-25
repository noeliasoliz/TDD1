using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Models
{
    public class cGrupoGrupoCliente
    {
        public GrupoCliente Buscar(int codigo)
        {
            List<GrupoCliente> lstGrupoClientes = new List<GrupoCliente>();
            GrupoCliente grupoCliente;

            using (SqlConnection conexion = ConexionBD.obtenerConexion())
            {
                string query = $"select * from GrupoCliente where CodGrupoCliente = {codigo}";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    grupoCliente = new GrupoCliente();
                    grupoCliente.CodGrupoCliente = reader.GetInt32(0);
                    grupoCliente.sNombreGrupo = reader.GetString(1);
                    grupoCliente.dPorcentajeDsto = reader.GetDouble(2);

                    lstGrupoClientes.Add(grupoCliente);
                }
                conexion.Close();
            }

            return lstGrupoClientes[0];
        }
    }
}
