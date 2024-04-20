using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class linQEj5Controller : ControllerBase
    {
        [HttpGet()]
        public List<string> Get([FromQuery] List<int> numeros)
        {
            var query = from n in numeros
                        let cuadrado = n * n
                        where cuadrado > 20
                        select $"{n} - {cuadrado}";

            return query.ToList(); //me falta hacer el branch


        }
    }
}
