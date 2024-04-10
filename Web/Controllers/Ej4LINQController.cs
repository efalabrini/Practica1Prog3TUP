using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej4LINQController : ControllerBase
    {
        [HttpGet()]
        public List<int> Get([FromQuery] int[] queryNum)
        {
            var list = queryNum.Take(5).OrderByDescending(x => x).ToList();
            
            return list;
        }
    }
}
