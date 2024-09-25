using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Models
{
    public class cVenta
    {
        public cVenta() { }

        public int GuardarVenta(Venta venta)
        {
            int retorna = 0;

            using (SqlConnection conexion = ConexionBD.obtenerConexion())
            {
                int conFactura = (venta.Factura) ? 1 : 0;
                string sSql = $"insert into Venta (NroVenta, codAlmacen, Descuento, Factura, Impuesto, codCliente, total) values ({venta.NroVenta}, {venta.codAlmacen}, {venta.Descuento}, {conFactura}, {venta.Impuesto}, {venta.objCliente.codCliente}, {venta.TotalPagar()}) ";
                SqlCommand command = new SqlCommand(sSql, conexion);

                retorna = command.ExecuteNonQuery();
            }
            return retorna;
        }

        public void GuardarDetalleVenta(List<DetalleVenta> detalleVenta)
        {
            using (SqlConnection conexion = ConexionBD.obtenerConexion())
            {
                foreach (DetalleVenta item in detalleVenta)
                {
                    string sSql = $"insert into DetalleVenta (NroVenta, SKU, Cantidad, PrecioUnitario, Descuento) values ({item.NroVenta},'{item.SKU}',{item.cantidad},{item.precioUnitario},{item.descuento})";
                    SqlCommand command = new SqlCommand(sSql, conexion);

                    command.ExecuteNonQuery();
                }
                
            }
        }
    }
}
