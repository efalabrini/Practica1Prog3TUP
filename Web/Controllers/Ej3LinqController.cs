using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej3LinqController : ControllerBase
    {
        [HttpGet()]
        public List<string> Get([FromQuery] List<string> word)
        {

            var query =
                from letter in word
                where letter.ToLower()[0] == 'b' | letter.ToLower().Last() == 'r'
                select letter.ToLower();

            return query.ToList();
        }
    }
}

