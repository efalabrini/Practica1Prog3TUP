using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej10Controller : ControllerBase
    {
        [HttpGet()]
        public string Get()
        {
            int cont = 0;
            List<int> pairNumbers = [];
            List<int> divisibleBy3 = [];

            while (cont < 100)
            {
                cont++;
                if (cont % 2 == 0)
                {
                    pairNumbers.Add(cont);

                    if (cont % 3 == 0)
                    {
                        divisibleBy3.Add(cont);
                    }
                }
                else if (cont % 3 == 0)
                {
                    divisibleBy3.Add(cont);
                }
            }



            return $"Lista de números pares: {string.Join(", ", pairNumbers)}\n, Lista de números divisibles por 3: {string.Join(", ", divisibleBy3)}";
        }
    }
}

/* dfgdfg
 * dggdf
 */
