using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej6LinqController : ControllerBase
    {
        [HttpGet()]
        public string[] Get([FromQuery] List<string> words)
        {
            var replacedWords = words.Select(x => x.ToLower().Replace("ia", "*")).ToArray();
            return replacedWords;


        }
    }
}








