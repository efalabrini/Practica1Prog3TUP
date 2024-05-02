using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinqEj3Controller : ControllerBase
    {
        [HttpGet()]
        public List<string> Get([FromQuery] List<string> lista)
        {
            var query = from string l in lista
                        where l.StartsWith("b", System.StringComparison.OrdinalIgnoreCase) && l.EndsWith("r", System.StringComparison.OrdinalIgnoreCase)
                        select l;
            return query.ToList();
        }
    }
}
