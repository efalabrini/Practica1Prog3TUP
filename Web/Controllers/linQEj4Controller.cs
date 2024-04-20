using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinqEj4Controller : ControllerBase
    {
        [HttpGet()]
        public List<int> Get([FromQuery] List<int> numeros)
        {
            var query = (from  n in numeros
                        orderby n descending
                        select n).Take(5);
            return query.ToList();
        }
    }
}
