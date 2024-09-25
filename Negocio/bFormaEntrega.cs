using Datos.Models;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class bFormaEntrega
    {

        public List<FormaEntrega> Listar()
        {
            cFormaEntrega cFormaEntrega = new cFormaEntrega();
            List<FormaEntrega> Lista;
            Lista = cFormaEntrega.Listar();
            return Lista;
        }
    }
}
