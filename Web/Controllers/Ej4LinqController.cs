using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej4LinqController : ControllerBase
    {
        [HttpGet()]
        public List<int> Get([FromQuery] List<int> list)
        {
            var query =
                from num in list
                where num > 0
                select num;

            return query.OrderByDescending(num => num).ToList();
        }
    }
}
