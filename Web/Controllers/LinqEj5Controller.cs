using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Linq;
using System.Collections.Generic;

namespace web.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class LinqEj5Controller : ControllerBase
    {
        [HttpGet]
        public List<string> Get([FromQuery] List<int> numeros)
        {
            var query = from num in numeros
                        where Math.Pow(num, 2) > 20
                        select $"{num}-{Math.Pow(num, 2)}";


            return query.ToList();

        }
    }
}