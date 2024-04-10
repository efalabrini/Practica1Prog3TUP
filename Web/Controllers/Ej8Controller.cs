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
            StringBuilder sb = new StringBuilder();
            int contador = 1;

            while (contador < 101)
            {
                sb.Append($"\n{contador}");
                contador++;
            }
            return sb.ToString();
        }
    }
}

//8) Recorrer los números del 1 al 100. Usar un bucle while.