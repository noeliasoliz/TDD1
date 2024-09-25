using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Models
{
    public class DetalleVenta
    {
        public int NroVenta { get; set; }
        public string SKU { get; set; }
        public int cantidad { get; set; }
        public double precioUnitario { get; set; }
        public double descuento { get; set; }
    }
}
