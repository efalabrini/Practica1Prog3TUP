using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LinqEj1Controller : ControllerBase
    {
        [HttpGet()]
        public int[] Get()
        {
            int[] numbers = [67, 92, 153, 15];

            var numQuery =
                from num in numbers
                where (num > 30 && num < 100)
                select num;

            return numQuery.ToArray();
        }
    }
}
