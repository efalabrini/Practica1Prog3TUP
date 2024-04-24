using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej4LinqController : ControllerBase
    {
        [HttpGet()]
        public List<int> Get([FromQuery] List<int> numeritos)
        {
           var query = from int num in numeritos 
                       where num > 0
                       select num;
            query = query.OrderByDescending(num => num); // orden descendente
            return query.Take(5).ToList(); // tomo solo los primeros 5

        }
    }
}