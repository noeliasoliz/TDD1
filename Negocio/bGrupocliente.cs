using Datos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class bGrupoCliente
    {
        public GrupoCliente Buscar(int codigoGrupo)
        {
            cGrupoGrupoCliente cGrupoGrupoCliente = new cGrupoGrupoCliente();
            GrupoCliente grupoCliente;

            grupoCliente = cGrupoGrupoCliente.Buscar(codigoGrupo);

            return grupoCliente;
        }
    }
}
