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
            int cont = 0;
            List<int> pairNumbers = [];

            while (cont < 100)
            {
                cont++;
                if (cont % 2 == 0)
                {
                    pairNumbers.Add(cont);
                }
            }



            return $"Lista de números pares: {string.Join(", ", pairNumbers)}\n";
        }
    }
}
