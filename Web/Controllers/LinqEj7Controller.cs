using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinqEj7Controller : ControllerBase
    {
        [HttpGet()]
        public IList<string> Get([FromQuery] string words)
        {
            return DevolverPalabrasCapitales(words);
        }

        public static IList<string> DevolverPalabrasCapitales(string cadena)
        {
            var splitedCadena = cadena.Split(' ');
            
            var result = 
                from word in splitedCadena
                where word.Equals(word.ToUpper())
                select word;

            return result.ToList();
        }
    }
}
