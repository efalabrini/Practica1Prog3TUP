using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej1LinqController : ControllerBase
    {
        [HttpGet()]
        public List<int> Get([FromQuery] int num1, [FromQuery] int num2, [FromQuery] int num3, [FromQuery] int num4, [FromQuery] int num5)
        {
            List<int> listNumbers = [num1, num2, num3, num4, num5];

            var numbersbetween20and100 = listNumbers.Where(x => x > 30 && x < 100).ToList();

            return numbersbetween20and100; 
        }
    }
}

