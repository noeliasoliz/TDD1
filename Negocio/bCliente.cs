using Datos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class bCliente
    {

        public Cliente Buscar(int codigoCliente)
        {
            cCliente cCliente = new cCliente();
            cGrupoGrupoCliente cGrupoGrupoCliente = new cGrupoGrupoCliente();
            Cliente cliente;

            cliente = cCliente.Buscar(codigoCliente);
            cliente.objGrupocliente = cGrupoGrupoCliente.Buscar(cliente.objGrupocliente.CodGrupoCliente);

            return cliente;
        }

    }
}
