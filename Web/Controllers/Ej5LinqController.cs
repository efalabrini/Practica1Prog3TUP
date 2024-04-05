using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej5LinqController : ControllerBase
    {
        [HttpGet()]
        public string[] Get([FromQuery] int[] queryNumbers)
        {
            var numbers = queryNumbers.Select(x => Math.Pow(x, 2)).ToArray();
            List<string> numbersAndSquare = new List<string>();

            for (int i = 0; i <numbers.Length; i++)
            {
                if (numbers[i] > 20)
                {
                    numbersAndSquare.Add($"{queryNumbers[i]}-{numbers[i]}");
                }
            }
            return numbersAndSquare.ToArray();


        }
    }
}






