using Datos.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class cProducto
    {
        public cProducto()
        {

        }

        public int AgregarProducto(Producto producto)
        {
            int retorna = 0;

            using (SqlConnection conexion = ConexionBD.obtenerConexion())
            {
                string sSql = $"insert into Producto (Codigo, Nombre, NombreExtranjero, codGrupo) values ('{producto.sCodigo}','{producto.sNombre}','{producto.sNombreExtranjero}',{producto.objGrpProd.sCodigo})";
                SqlCommand command = new SqlCommand(sSql, conexion);

                retorna = command.ExecuteNonQuery();
            }
            return retorna;
        }

        public Producto Buscar(string SKU)
        {
            List<Producto> lstproductos = new List<Producto>();
            Producto producto = new Producto();

            using (SqlConnection conexion = ConexionBD.obtenerConexion())
            {
                string query = $"select * from Producto where Codigo = '{SKU}'";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    producto = new Producto();
                    producto.sCodigo = reader.GetString(0);
                    producto.sNombre = reader.GetString(1);
                    producto.sNombreExtranjero = reader.GetString(2);

                    lstproductos.Add(producto);
                }
                conexion.Close();
            }

            return lstproductos[0];
        }
    }
}
