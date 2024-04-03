using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej8Controller : ControllerBase
    {
        [HttpGet()]
        public string Get()
        {
            StringBuilder numeros = new StringBuilder(); // constructor de cadenas
            
            int x = 0;
    
            while(x <= 100){
                numeros.Append(x.ToString()); // agrego el numero en esa iteracion y lo convierto a string
                numeros.Append(", "); // agrego comas
                x++; // aumento contador para contar cuantos numeros pasaron
            }

            return "Enhorabuena, llegaste a los 100!\n" + " " + numeros.ToString();
        }
    }
}
