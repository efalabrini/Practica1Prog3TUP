using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej4Controller : ControllerBase
    {
        [HttpGet()]
        public void Get([FromQuery] int num1, [FromQuery] int num2)
        {
            if (num1 > num2)
            {
                Console.Write($"{num1} es mayor que {num2}");
            }
            else if (num2 > num1)
            {
                Console.Write($"{num2} es mayor que {num1}");
            }
            else
            {
                Console.Write($"Los números {num1} y {num2} son iguales");
            }
        }
    }
}



//4) Pedir dos números al usuario por teclado y decir qué número es el mayor.
