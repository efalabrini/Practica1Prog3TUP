using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej2LinqController : ControllerBase
    {
        [HttpGet()]
        public string[] Get([FromQuery] string[] inputList)
        {
            var wordQuery =
                from word in inputList
                where word.Length >= 5
                select word.ToUpper();

            return wordQuery.ToArray();
        }
    }
}

