using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Models
{
    public class Producto
    {
        public bool bVenta { get; set; }
        public bool bCompra { get; set; }
        public bool bInventario { get; set; }
        public string sCodigo { get; set; }
        public string sNombre { get; set; }
        public string sNombreExtranjero { get; set; }
        public GrupoProducto objGrpProd { get; set; }
    }
}
