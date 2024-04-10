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
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i < 101; i++)
            {
                sb.Append($"\n{i}");
            }
            return sb.ToString();
        }
    }
}

//7) Recorrer los números del 1 al 100. Usar un bucle for.
