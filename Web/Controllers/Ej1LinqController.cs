using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej1LinqController : ControllerBase
    {
        [HttpGet()]
        public List<int> Get([FromQuery] List<int> list)
        {
            var query =
                from num in list
                where num > 30 && num < 100
                select num;

            return query.ToList(); 
        }
    }
}