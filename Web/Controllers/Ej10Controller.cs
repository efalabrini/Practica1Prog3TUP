using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej10Controller: ControllerBase
    {
        [HttpGet()]
        public string Get()
        {
            List<int> pairNumbers = new List<int>();
            List<int> numbersDivisibleByThree = new List<int>();
            
            for(int i = 1; i < 101; i++)
            {
                if (i % 2 == 0 || i % 3 == 0)
                {
                    if (i % 2 == 0)
                    {
                        pairNumbers.Add(i);
                    }
                    if (i % 3 == 0)
                    {
                        numbersDivisibleByThree.Add(i);
                    }
                }

            }
            return $"Pares:{string.Join(", ", pairNumbers)} \nDivisibles por 3: {string.Join(", ", numbersDivisibleByThree)}";
        }
    }
}
