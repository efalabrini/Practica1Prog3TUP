using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej10Controller : Controller
    {
        [HttpGet]
        public string Get()
        {
            List<int> numPares = [];
            List<int> numDivisibles3 = [];

            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    numPares.Add(i);

                    if (i % 3 == 0)
                    {
                        numDivisibles3.Add(i);
                    }
                }
                else if (i % 3 == 0)
                {
                    numDivisibles3.Add(i);
                }
            }

            return $"Los numeros pares son: {string.Join(", ", numPares)}\n Los numeros divisibles por 3 son {string.Join(", ", numDivisibles3)}";

        }
    }
}
