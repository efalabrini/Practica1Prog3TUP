using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej2LinqController : ControllerBase
    {
        [HttpGet()]
        public List<string> Get([FromQuery] List<string> palabritas) //deberia devolver las palabras ingresadas
        {
           var query = from string palabra in palabritas // query
                       where palabra.Length >= 5
                       select palabra.ToUpper();

            return query.ToList(); // ejecucion



        }
    }
}