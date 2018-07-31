using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Belcorp.ApiFGH.ADApi.Service
{
    public interface ILDAPAgent
    {
        string ObtenerImagenPorCodigo(string codigo);
        string ObtenerImagenPorCorreo(string codigo);
        
    }
}
