using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej3LinqController : ControllerBase
    {
        [HttpGet()]
        public List<string>Get([FromQuery] List<string> lista)
        {

            var listQuery =
                from string l in lista
                where l[0].ToString() == "b" && l[l.Length-1].ToString() == "r"
                select l;

            return listQuery.ToList();
        }
    }
}
