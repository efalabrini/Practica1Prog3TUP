using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Linq;
using System.Collections.Generic;

namespace web.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class LinqEj5Controller : ControllerBase
    {
        [HttpGet]
        public List<string> Get([FromQuery] List<string> lista)
        {
            var query = from palabras in lista
                        select palabras.Replace("ia", "*");


            return query.ToList();

        }
    }
}

//6) Escriba una consulta que sustituya la cadena 'ia' por el asterisco (*) en una lista de palabras dada. Para simplificar escribir todo sin acento.
//Ejemplo: "estudiar", "caminar", "dia" →  "estud*r", "caminar", "d*"


