using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej5LinqController : ControllerBase
    {
        [HttpGet()]
        public string Get([FromQuery] List<int> numeritos)
        {
           var query = from int num in numeritos 
                       where (num * num) > 20 // solo si el cuadrado es mayor a 20
                       select $"Num: {num} - Cuadrado: {num * num}";

                return string.Join(", ", query);

        }
    }
}