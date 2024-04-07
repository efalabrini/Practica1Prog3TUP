using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej6LinqController : ControllerBase
    {
        [HttpGet()]
        public List<string> Get([FromQuery] List<string> list)
        {
            var result = list.Select(word => word.Replace("ia", "*")).ToList();
            return result;
        }
    }
}
