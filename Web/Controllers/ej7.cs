using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace Web.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ej7 : ControllerBase
    {
        [HttpGet()]
        public string Get()

        {
            string numero = "";
            for (int i = 0; i <= 100; i++)
            {
                 numero =+ i + "";
            }

            return numero;

        }

    }

}
