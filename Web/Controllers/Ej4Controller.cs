using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej4Controller : ControllerBase
    {
        [HttpGet()]
        public int Get([FromQuery] int num1, [FromQuery] int num2)
        {
            int mayor = 0;

            if (num1 > num2)
            {
                mayor = num1;
            }else {mayor = num2;}

            return mayor;
        }
    }
}
