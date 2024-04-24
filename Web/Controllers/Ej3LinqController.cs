using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej3LinqController : ControllerBase
    {
        [HttpGet()]
        public List<string> Get([FromQuery] List<string> lista)
        {
            var wordQuery =
                from word in lista
                where word.StartsWith("b") && word.EndsWith("r")
                select word;

            return wordQuery.ToList();
        }
    }
}
