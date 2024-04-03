using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej9Controller : ControllerBase
    {
        [HttpGet()]
        public string Get()
        {
            StringBuilder numeros = new StringBuilder(); // constructor de cadenas
    
            for(int x = 0; x <= 100;x++){
                if(x%2 == 0){
                    numeros.Append(x.ToString()); // agrego el numero en esa iteracion y lo convierto a string
                    numeros.Append(", "); // agrego comas
                }
            }

            return "Enhorabuena, estas viendo los pares dentro del 1 al 100.\n" + " " + numeros.ToString();
        }
    }
}
