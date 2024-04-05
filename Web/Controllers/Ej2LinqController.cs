using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej2LinqController : ControllerBase
    {
        [HttpGet()]
        public string[] Get([FromQuery] string[] queryString)
        {
            var filteredWords = queryString.Where(word => word.Length >= 5).ToArray(); 
            var upperWords = filteredWords.Select(word => word.ToUpper()).ToArray();    
            return upperWords;


        }
    }
}
