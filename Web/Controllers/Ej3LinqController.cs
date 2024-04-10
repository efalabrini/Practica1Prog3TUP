using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej3LinqController : ControllerBase
    {
        [HttpGet()]
        public string[] Get([FromQuery] string[] stringList)
        {

            var stringQuery =
                from word in stringList
                where word.StartsWith("b") && word.EndsWith("r")
                select word;

            return stringQuery.ToArray();
        }
    }
}
