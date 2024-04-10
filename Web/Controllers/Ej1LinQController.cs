using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej1LinQController : ControllerBase
    {
        [HttpGet()]
        public int[] Get([FromQuery] List<int> intList)
        {
            var result = from i in intList
                         where i > 30
                         && i < 100
                         select i;
            return result.ToArray();
        }
    }
}