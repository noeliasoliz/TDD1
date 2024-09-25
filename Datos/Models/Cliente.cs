using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Models
{
    public class Cliente
    {
        public int codCliente { get; set; }
        public string snombreCliente { get; set; }
        public GrupoCliente objGrupocliente { get; set; }

    }
}
