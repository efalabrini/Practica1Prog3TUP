using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej1_LinqController : ControllerBase
    {
        [HttpGet()]
        public List<int> Get([FromQuery] int num1, [FromQuery] int num2, [FromQuery] int num3, [FromQuery] int num4, [FromQuery] int num5)
        {
            List<int> numbers = [num1, num2, num3, num4, num5];

            var between30and100Query =
                from num in numbers
                where num > 30 && num < 100
                select num;

            var filteredNumbers = new List<int> {};

            foreach (int num in between30and100Query)
            {
                filteredNumbers.Add(num);
            }

            return filteredNumbers;
        }
    }
}
