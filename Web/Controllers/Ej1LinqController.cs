using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej1LinqController : ControllerBase
    {
        [HttpGet()]
        public List<int> Get([FromQuery] List<int> onelist)
        {
            var numbers = onelist.Where(x => x > 30 && x < 100).ToList();
            return numbers;
        }
    }
}
