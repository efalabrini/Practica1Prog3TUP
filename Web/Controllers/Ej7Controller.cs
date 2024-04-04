using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej7Controller : ControllerBase
    {
        [HttpGet()]
        public string Get()
        {
            StringBuilder numeros = new StringBuilder(); // constructor de cadenas

            for (int x = 1; x <= 100; x++)
            {
                numeros.Append(x.ToString()); // agrego el numero en esa iteracion y lo convierto a string
                numeros.Append(", "); // agrego comas
            }
            return numeros.ToString();
        }
    }
}