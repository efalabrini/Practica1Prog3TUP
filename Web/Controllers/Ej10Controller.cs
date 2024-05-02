using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Eventing.Reader;
using System.Reflection;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej10Controller : ControllerBase
    {
        [HttpGet()]
        public string Get()
        {
            List<int> div2 = [];
            List<int> div3 = [];

            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    if (i % 3 == 0)
                    {
                        div2.Add(i);
                        div3.Add(i);
                    }
                    else
                    {
                        div2.Add(i);

                    }
                }
                else if (i % 3 == 0)
                {
                    div3.Add(i);
                }  
            }
            return $"Numeros pares: {string.Join(", ", div2)}\nNumeros divisibles por 3: {string.Join(", ", div3)}";
        }
    }
}