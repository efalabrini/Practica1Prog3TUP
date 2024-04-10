using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej2LinqController: ControllerBase
    {
        [HttpGet()]
        public List<string> Get([FromQuery] string word1 , [FromQuery] string word2)
        {
            List<string> words = [word1, word2];
            var wordsFiltered = words.Where(item => item.Length > 5).ToList();
            var wordsFilteredUpper = wordsFiltered.Select(item => item.ToUpper()).ToList();
            return wordsFilteredUpper;
        }
    }
}
