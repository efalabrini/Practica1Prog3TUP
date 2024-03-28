using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej4Controller : ControllerBase
    {
        [HttpGet()]
        public string Get([FromQuery] int number1, [FromQuery] int number2)
        {
            if (number1 > number2)
            {
                return $"El numero mayor es el {number1}";
            }
            else if (number1 == number2) 
            {
                return "Los numeros ingresados son el mismo numero, ninguno es mayor"; //retorno en caso de numeros iguales
            }
            else 
            {
                return $"El numero mayor es el {number2}";
            }
        }
    }
}
