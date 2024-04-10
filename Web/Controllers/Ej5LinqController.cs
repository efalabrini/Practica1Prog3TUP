using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej5LinqController : ControllerBase
    {
        [HttpGet()]
        public List<string> Get([FromQuery] List<int> list)
        {
            var query =
                from num in list
                where num * num > 20
                select $"{num} - {num * num}";

            return query.ToList();
        }
    }
}
