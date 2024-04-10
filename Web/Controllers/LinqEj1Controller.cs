using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinqEj1Controller : ControllerBase
    {
        [HttpGet()]
        public List<int> Get([FromQuery] List<int> list)
        {
            var query = from int item in list
                        where item > 30 && item < 100
                        select item;

            return query.ToList();
        }
    }
}
