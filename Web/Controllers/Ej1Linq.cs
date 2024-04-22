using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;


namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej1LinQController : ControllerBase
    {
        [HttpGet]
        public List<int> Get([FromQuery] List<int> List)
        {

            var filteredresult = List.Where(x => x > 30 && x < 100).ToList();


            return filteredresult;
        }
    }

}
