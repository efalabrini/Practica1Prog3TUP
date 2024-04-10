using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinqEj3Controller : ControllerBase
    {
        [HttpGet()]
        public List<string> Get([FromQuery] List<string> list)
        {
            var query = from string w in list
                        where w.StartsWith("b") && w.EndsWith("r")
                        select w;

            return query.ToList();
        }
    }
}