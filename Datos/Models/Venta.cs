using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Models
{
    public class Venta
    {
        public int NroVenta { get; set; }        
        public int codAlmacen { get; set; }
        public double Descuento { get; set; } //importe a descontar
        public bool Factura { get; set; }
        public double Impuesto { get; set; } //importe impuesto
        public Cliente objCliente { get; set; }
        public List<DetalleVenta> items { get; set; }

        public double TotalVenta()
        {
            double totalVenta = 0;
            if (items.Count > 0)
            {
                foreach (DetalleVenta item in items)
                {
                    totalVenta += item.cantidad * item.precioUnitario;
                }
            }
            return totalVenta;
        }
        public double TotalPagar()
        {
            double totalVenta = TotalVenta();
            totalVenta = totalVenta - Descuento + Impuesto;
            return totalVenta;
        }
    }
}
