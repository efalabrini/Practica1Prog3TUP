
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej1Controller : ControllerBase
    {
        [HttpGet()]
        public int Get([FromQuery] int var1, [FromQuery] int var2, [FromQuery] int var3)
        {
            
            int result = var1 + var2 + var3;
            return result;
        }
    }
}
