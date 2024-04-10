using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej4_LinqController : ControllerBase
    {
        [HttpGet()]
        public int[] Get([FromQuery] int[] numbers)
        {
            var query =
                from num in numbers.OrderDescending()
                where numbers.ToList().IndexOf(num) > numbers.Length - 6
                select num;

            return query.ToArray();
        }
    }
}
