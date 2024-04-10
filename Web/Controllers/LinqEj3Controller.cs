using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinqEj3Controller : ControllerBase
    {
        [HttpGet()]
        public List<string> Get([FromQuery] List<string> palabras)
        {
            var query = from p in palabras
                        where p.StartsWith("b") && p.EndsWith("r")
                        select p;
            return query.ToList();
        }
    }
}