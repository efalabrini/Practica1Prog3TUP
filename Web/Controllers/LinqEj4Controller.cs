using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LinqEj4Controller : ControllerBase
    {
        [HttpGet()]
        public int[] Get([FromQuery] int[] numbers)
        {
            Array.Sort(numbers);
            Array.Reverse(numbers);

            var numQuery =
                from n in numbers
                where n > 0
                select n;

            return numQuery.ToArray();
        }
    }
}
