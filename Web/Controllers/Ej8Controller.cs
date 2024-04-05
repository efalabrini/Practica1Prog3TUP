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
        public int Get()
        {
            int numeros = 1;
            
            while(numeros < 100)
            {
                numeros++;
            }
            return numeros;
        }
    }
}
