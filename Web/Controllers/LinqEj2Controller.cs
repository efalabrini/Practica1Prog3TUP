using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej2LinqController : ControllerBase
    {
        [HttpGet("consulta2")]
        public List<string> Consulta2([FromQuery] List<string> words)
        {
            var result = words.Where(word => word.Length >= 5).Select(word => word.ToUpper()).ToList();
            return result;
        }
    }
}
