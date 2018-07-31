using Belcorp.ApiFGH.ADApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.DirectoryServices;
using Microsoft.Extensions.Options;

namespace Belcorp.ApiFGH.ADApi.Service
{
    public class LDAPAgent : ILDAPAgent
    {

        private readonly LdapService _config;
        public LDAPAgent(IOptions<LdapService> config)
        {
            _config = config.Value;
        }
        
        public string ObtenerImagenPorCodigo(string codigo)
        {
            return "Desde Imagen por codigo " + _config.AdminCn;
        }

        public string ObtenerImagenPorCorreo(string codigo)
        {
            return "Desde Imagen por correo";
        }

        #region Para las imagenes por defecto

        public string ObtenerImagenEnBlanco()
        {
            return "";
        }

        #endregion
    }
}
