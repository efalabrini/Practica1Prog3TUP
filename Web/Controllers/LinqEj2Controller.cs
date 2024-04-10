using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class linqEj2Controller : ControllerBase
    {
        [HttpGet()]
        public List<string> Get([FromQuery] List<string> list)
        {
            var quary = from string w in list
                        where w.Length >= 5
                        select w.ToUpper();

            return quary.ToList();
        }
    }
}
