using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej3LinqController : ControllerBase
    {
        [HttpGet()]
        public List<string> Get([FromQuery] List<string> list)
        {
            var query =
                from word in list
                where word.ToLower().StartsWith('b') && word.ToLower().EndsWith('r')
                select word;

            return query.ToList();
        }
    }
}