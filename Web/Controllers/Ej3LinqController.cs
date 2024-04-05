using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej3LinqController : ControllerBase
    {
        [HttpGet()]
        public string[] Get([FromQuery] string[] queryString)
        {
            var filteredWords = queryString.Where(word => word.ToLower().StartsWith('b') && word.ToLower().EndsWith('r')).ToArray();
            return filteredWords;

            


        }
    }
}
