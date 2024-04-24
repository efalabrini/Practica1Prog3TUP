using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LinqEj6Controller : ControllerBase 
    {
        [HttpGet]
        public List<string> Get([FromQuery] List<string> lista)
        {
            var query =
                from palabras in lista
                select palabras.Replace("ia", "*");

            return query.ToList();
        }
    }
}
