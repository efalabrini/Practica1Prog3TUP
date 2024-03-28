using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej4Controller : ControllerBase
    {
        [HttpGet()]
        public string Get([FromQuery] int num1, [FromQuery] int num2) 
        { 
            if (num1 > num2)
            {
                return $"{num1} es el mayor de los números ingresados.";
            }
            else
            {
                if (num2 > num1)
                {
                    return $"{num2} es el mayor de los números ingresados."; ;
                }
                else
                {
                    return $"Los números ingresados son iguales."; ;
                }
            }
           
        }
    }
}
