using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej2LinqController : Controller
    {
        [HttpGet()]
        public List<string> Get([FromQuery] List<string> list)
        {
            var result = list.Where(word => word.Length >= 5).Select(word => word.ToUpper()).ToList(); //where es como .filter() y select como .map()
            return result;


        }
    }
}
