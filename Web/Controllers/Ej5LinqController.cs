using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej5LinqController : ControllerBase
    {
        [HttpGet()]
        public List<string> Get([FromQuery] List<int> numbers)
        {
            var query =

                from n in numbers
                where n * n > 20
                select $"{n} - {n*n}";
       
            return query.ToList();
        }
    }
}

