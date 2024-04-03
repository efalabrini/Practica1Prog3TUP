using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ej4 : ControllerBase
    {
        [HttpGet()]
        public string Get([FromQuery] int nro1, [FromQuery] int nro2)

        {
            if (nro1 > nro2)
            {
                return $"El nro mayor es el nro1 {nro1}";


            }
            else if (nro1 == nro2)
                {
                return $"El nro 1 {nro1} es igual al nro2 {nro2}";
                }
            else
            {
                return $"El nro mayor es el nro2 {nro2}";
            }



        }

    }
}
