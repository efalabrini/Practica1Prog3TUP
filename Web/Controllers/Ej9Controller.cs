using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


    public class Ej9Controller : ControllerBase
    {
        [HttpGet()]
        public Array Get()
        {
            List<int> pairNumbers = new();

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    pairNumbers.Add(i);
                }
            }


            return pairNumbers.ToArray(); // no me dejaba retornar una lista asiq transformo la lista en array y la retorno
        }
    }
}