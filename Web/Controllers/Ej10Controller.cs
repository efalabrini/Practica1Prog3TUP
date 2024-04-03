using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej10Controller : ControllerBase
    {
        [HttpGet()]
        public IActionResult Get()
        {
            List<int> pairNumbers = new List<int>();
            List<int> divisibleByThree = new List<int>();
            int i = 1;
            while (i <= 100)
            {
                if (i % 2 == 0)
                {
                    pairNumbers.Add(i);
                }
                else if (i % 3 == 0)
                {
                    divisibleByThree.Add(i);
                }
                i++;
            }

            var result = new Dictionary<string, List<int>>();
            result.Add("pairNumbers", pairNumbers);
            result.Add("divisibleByThree", divisibleByThree);

            return Ok(result);
        }
    }
}
