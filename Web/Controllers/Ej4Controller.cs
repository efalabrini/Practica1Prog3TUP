using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej4Controller : ControllerBase
    {
        [HttpGet()]
        public string Get([FromQuery] int var1, [FromQuery] int var2)
        {
            string response = "Son iguales";
            if (var1 > var2) 
            {
                response = $"El valor {var1} es el mayor";
            }
            if (var2 > var1)
            {
                response = $"El valor {var2} es el mayor";
            }
            return response;
        }
    }
}

//4) Pedir dos números al usuario por teclado y decir qué número es el mayor.

