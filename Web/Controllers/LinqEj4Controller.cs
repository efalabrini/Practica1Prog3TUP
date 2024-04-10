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
            var numquery =
                (from num in numbers
                 orderby num descending
                 select num).Take(5);

            return numquery.ToList();
        }
    }
}