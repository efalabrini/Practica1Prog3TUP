using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EJ8 : ControllerBase
    {

        [HttpGet()]
        public string Get()
        {
            int numero = 0;
            while (numero != 100)
            {
                numero++;
                
            }
            return $"el numero es {numero}";

        }
    }
}
