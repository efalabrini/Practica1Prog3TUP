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
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i < 101; i++)
            {
                if (i % 2 == 0)
                {
                    sb.Append($"\n{i}");
                }
                
            }
            return sb.ToString();
        }
    }
}

//9) Recorrer los números del 1 al 100. Mostrar los números pares. Usar el tipo de bucle que quieras.
