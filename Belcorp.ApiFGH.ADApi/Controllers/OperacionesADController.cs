using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Belcorp.ApiFGH.ADApi.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Belcorp.ApiFGH.ADApi.Controllers
{
    //[Produces("application/json")]
    //[Route("api/Operacion")]
    public class OperacionesADController : BaseController
    {
        ILDAPAgent _agente;

        public OperacionesADController(ILDAPAgent lDAPAgent)
        {
            _agente = lDAPAgent;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet]
        public IActionResult ImagenPorCodigo(string codigo)
        {
            return Ok(_agente.ObtenerImagenPorCodigo(codigo));
        }

        [HttpGet]
        public IActionResult ImagenPorCorreo(string codigo)
        {
            return Ok(_agente.ObtenerImagenPorCorreo(codigo));
        }
    }
}