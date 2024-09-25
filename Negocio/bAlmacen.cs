using Datos;
using Datos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class bAlmacen
    {
        public List<Almacen> Listar()
        {
            cAlmacen cAlmacen = new cAlmacen();
            List<Almacen> Lista;
            Lista = cAlmacen.Listar();
            return Lista;
        }
    }
}
