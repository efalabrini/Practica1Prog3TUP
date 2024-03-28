using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


    public class Ej9Controller : ControllerBase
    {
        [HttpGet()]
        public string Get()
        {
            List<int> pairNumbers = new();

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    pairNumbers.Add(i);
                }
            }


            return $"{string.Join(", ", pairNumbers)}";
        }
    }
}