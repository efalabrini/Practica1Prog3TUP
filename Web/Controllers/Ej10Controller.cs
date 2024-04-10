using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Ej10Controller : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            List<int> pairNumbers = new List<int>();
            List<int> module3 = new List<int>();

            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    pairNumbers.Add(i);

                    if (i % 3 == 0)
                    {
                        module3.Add(i);
                    }
                }else if(i % 3 == 0)
                {
                    module3.Add(i);
                }
            }
            return $"Los numeros pares son: {string.Join(", ", pairNumbers)}\n Los numeros divisibles por 3 son {string.Join(", ", module3)}";
        }
    }
}
