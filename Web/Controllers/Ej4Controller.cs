using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej4Controller : ControllerBase
    {
        [HttpGet()]
        public string Get([FromQuery] string num1, [FromQuery] string num2)
        {
            string resultado;
   
            if (int.Parse(num1) > int.Parse(num2))
            {
                resultado = $"El número mayor es: {num1}";
            }
            else if (int.Parse(num2) > int.Parse(num1))
            {
                resultado = $"El número mayor es: {num2}";
            }
            else
            {   
                resultado = "Los números son iguales!";
            }

            return resultado;



        }
    }
}
