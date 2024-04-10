using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinqEj5Controller : ControllerBase
    {
        [HttpGet()]
        public List<string> Get([FromQuery] List<string> words)
        {

            var result =
                from word in words
                select word.Replace("ia" , "*");

            return result.ToList();
        }
    }
}
