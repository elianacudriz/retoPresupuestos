using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Presupuesto.LogicaCarpeta;
using Presupuesto.Entidades;

namespace Presupuesto.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PresupuestoController : ControllerBase
    {
        private readonly ILogica _logica;
        public PresupuestoController(ILogica logica)
        {
            _logica = logica;
        }

        [HttpPost]
        public IActionResult entrada(DatoEntrada dato)
        {
          return Ok(_logica.ActualizacionInformacionEntrada(dato));
        }

        [HttpGet]
        public IActionResult leer()
        {
            return quehago();
        }


        private IActionResult quehago(){

            if (!String.IsNullOrEmpty(HttpContext.Request.Query["parametro"]))
                {
                    var categoria = HttpContext.Request.Query["parametro"];
                    return Ok(_logica.GetByCategoria(categoria));
                }
            return Ok( _logica.leerCsv());

        }
        
            
    }
}
