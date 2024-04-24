using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej5LinqController : ControllerBase
    {
        [HttpGet()]
        public List<string> Get([FromQuery] List<int> list)
        {
            var result = list
                .Where
                (
                    number => (number * number) > 20
                )
                .Select
                (
                    number => $"{number} - {number*number}"
                )
                .ToList();
            
            return result;
        }
    }
}