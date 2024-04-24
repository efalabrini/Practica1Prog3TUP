using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej3LinqController : Controller
    {
        [HttpGet()]
        public List<string> Get([FromQuery] List<string> list)
        {
            var result = list
                .Where(
                    word => word.Trim().ToLower()[0] == 'b' 
                    && 
                    word.Trim().ToLower()[word.Trim().Length - 1] == 'r'
                    )
                .ToList(); 
            return result;

        }
    }
}