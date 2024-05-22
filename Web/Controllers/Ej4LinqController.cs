using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej4LinqController : ControllerBase
    {
        [HttpGet()]
        public List<int> Get([FromQuery] List<int> numbers)
        {

            var query =
                from n in numbers
                where n > 0
                orderby n ascending
                select n;

            return query.ToList();
        }
    }
}

