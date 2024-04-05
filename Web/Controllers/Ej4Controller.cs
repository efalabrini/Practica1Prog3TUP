using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej4Controller : ControllerBase
    {
        [HttpGet()]
        public string Get([FromQuery] int numero1, [FromQuery] int numero2)
        {
            if(numero1 > numero2)
            {
                string result = $"{numero1} es el numero mas grande";

                return result;

            }else
            {
                string result = $"{numero2} es el numero mas grande";
                return result;
            }
        }
    }
}
