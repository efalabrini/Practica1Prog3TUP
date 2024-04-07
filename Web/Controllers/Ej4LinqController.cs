using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej4LinqController : ControllerBase
    {
        [HttpGet()]
        public List<int> Get([FromQuery] List<int> list)
        {
            var result = list.OrderByDescending(number => number).ToList();
            return result.GetRange(0,5);
        }
    }
}