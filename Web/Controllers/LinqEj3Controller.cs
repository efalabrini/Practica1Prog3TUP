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
        [HttpGet("consulta3")]
        public List<string> Consulta3([FromQuery] List<string> words)
        {
            var result = words.Where(word => word.ToLower().StartsWith("b") && word.EndsWith("r")).ToList();
            return result;
        }
    }
}
