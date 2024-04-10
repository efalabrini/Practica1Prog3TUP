using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinqEj2Controller: ControllerBase
    {
        [HttpGet()]
        public string[] Get([FromQuery] string[] words)
        {
            var wordQuery =
                from word in words
                where word.Length >= 5
                select word.ToUpper();
                

                return wordQuery.ToArray();
        }

    }
}
