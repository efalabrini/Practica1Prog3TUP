using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej2LinqController : ControllerBase
    {
        [HttpGet()]
        public string[] Get([FromQuery] List<string> word)
        {
            var query =
                from w in word
                where w.Length >= 5
                select w.ToUpper();
            
            return query.ToArray();

        }
    }
}

