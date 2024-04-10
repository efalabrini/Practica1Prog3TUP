using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej1LINQController : ControllerBase
    {
        [HttpGet()]
        public List<int> Get([FromQuery] int[] queryNum)
        {

            var query =
                from num in queryNum
                where num > 30 && num < 100
                select num;

            return query.ToList();
        }
    }
}
