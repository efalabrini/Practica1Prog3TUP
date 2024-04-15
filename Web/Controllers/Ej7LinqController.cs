using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Linq;
using System.Collections.Generic;


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
            var word = cadena.Split(" ");

            var query =
                from w in word
                where w == (w.ToUpper())
                select w;

            return query.ToList();
        }
    }
}