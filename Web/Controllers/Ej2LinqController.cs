using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej2LinQController : ControllerBase
    {
        [HttpGet()]
        public string[] Get([FromQuery] List<string> words)
        {
            var queryResult = from i in words
                              where i.Length >= 5
                              select i.ToUpper();
            return queryResult.ToArray();
        }
    }
}