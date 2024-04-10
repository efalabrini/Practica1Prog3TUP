using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej2_LinqController : ControllerBase
    {
        [HttpGet()]
        public List<string> Get([FromQuery] string word1, [FromQuery] string word2, [FromQuery] string word3, [FromQuery] string word4, [FromQuery] string word5)
        {
            List<string> words = [word1, word2, word3, word4, word5];

            var more4LettersQuery =
                from word in words
                where word.Length > 4
                select word;

            var filteredWords = new List<string> { };

            foreach (string word in more4LettersQuery)
            {
                filteredWords.Add(word.ToUpper());
            }

            return filteredWords;
        }
    }
}
