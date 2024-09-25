using Datos.Models;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class bFormaPago
    {

        public List<FormaPago> Listar()
        {
            cFormaPago cFormaPago = new cFormaPago();
            List<FormaPago> Lista;
            Lista = cFormaPago.Listar();
            return Lista;
        }
    }
}
