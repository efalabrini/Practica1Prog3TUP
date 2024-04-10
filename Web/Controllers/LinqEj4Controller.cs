using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinqEj4Controller : ControllerBase
    {
        [HttpGet()]
        public List<int> Get([FromQuery] List<int> numbers)
        {
            var numquery = numbers.OrderByDescending(x => x).ToList();
            return numquery.GetRange(0, 5);
        }
    }
}