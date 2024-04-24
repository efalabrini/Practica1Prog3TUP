using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej7LinqController : ControllerBase
    {
        [HttpGet()]
        public IList<string> Get([FromQuery] string cadena)
        {
            
           return DevolverPalabrasCapitales(cadena);

        }

        public static IList<string> DevolverPalabrasCapitales(string cadena)
        {
            var listWords = cadena.Split();
            
            return listWords
                .Where
                (
                    word => word == word.ToUpper()
                )
                .ToList();
        }
    }
}
