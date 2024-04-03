using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej9Controller : ControllerBase
    {
        [HttpGet()]
        public List<int> Get()
        {
            List<int> numbers = new List<int>();
            int i = 1;
            while (i <= 100)
            {
                if (i % 2 == 0) 
                {
                    numbers.Add(i);
                }
                i++;
            }
            return numbers;
        }
    }
}
