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
        [HttpGet("consulta4")]
        public List<int> Consulta4([FromQuery] List<int> numbers)
        {
            var result = numbers.OrderByDescending(num => num).Take(5).ToList();
            return result;
        }
    }
}
