using Datos;
using Datos.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class bProducto
    {
        public cProducto cProducto = new cProducto();
        //public bool bVenta { get; set; }
        //public bool bCompra { get; set; }
        //public bool bInventario { get; set; }
        //public string sCodigo { get; set; }
        //public string sNombre { get; set; }
        //public string sNombreExtranjero { get; set; }
        //public GrupoProducto objGrpProd { get; set; }

        public bProducto()
        {

        }


        private string ObtenerultimoCodigo(string sPrefijo)
        {
            return "0001";
        }
    
        public void AgregarProducto(Producto producto)
        {
            cProducto.AgregarProducto(producto);
        }
        public Producto Buscar(string SKU)
        {
            return cProducto.Buscar(SKU);
        }
    }
}
