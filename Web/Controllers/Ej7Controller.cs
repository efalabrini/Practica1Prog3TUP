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
            StringBuilder numeros = new StringBuilder();
            for (int i = 0; i <= 100; i++) 
            {
             numeros.Append(i.ToString());
             numeros.Append(", ");
            }
            return numeros.ToString();
        }
    }
}
