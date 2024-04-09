using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej7LinqController : ControllerBase
    {
        [HttpGet()]
        public IList<string> Get([FromQuery] string words)
        {
            var selectedWords = DevolverPalabrasCapitales(words);
            return selectedWords;
        }

        public static IList<string> DevolverPalabrasCapitales(string words)
        {
            string[] separateWords = words.Split(' '); 
            var upperWords = separateWords.Where(word => word == word.ToUpper());
            return upperWords.ToList();

        }
    }
}



