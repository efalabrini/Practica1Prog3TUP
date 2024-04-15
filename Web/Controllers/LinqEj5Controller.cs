using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LinqEj5Controller : ControllerBase
    {
        [HttpGet()]
        public List<string> Get([FromQuery] List<int> numbers)
        {
            var numQuery =
                from n in numbers
                where n*n > 20
                select $"{n} - {n*n}";

            return numQuery.ToList();
        }
    }
}
