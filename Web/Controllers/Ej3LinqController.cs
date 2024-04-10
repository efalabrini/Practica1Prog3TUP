using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej3LinQController : ControllerBase
    {
        [HttpGet()]
        public string[] Get([FromQuery] List<string> words)
        {
            var queryResult = from i in words
                              where i[0] == 'b'
                              && i.Last() == 'r'
                              select i;
            return queryResult.ToArray();
        }
    }
}