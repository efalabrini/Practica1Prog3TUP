using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinqEj5Controller : ControllerBase
    {
        [HttpGet()]
        public List<string> Get([FromQuery] List<int> numbers)
        {
            var numbersAndSquares =
                from num in numbers
                where num*num > 20
                select $"{num} - {num * num}";

            return numbersAndSquares.ToList();
        }
    }
}