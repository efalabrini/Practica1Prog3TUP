using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej10Controller : ControllerBase
    {
        [HttpGet()]
        public string Get()
        {
            StringBuilder pares = new StringBuilder();
            StringBuilder divisiblesPor3 = new StringBuilder();
            StringBuilder resultado = new StringBuilder();


            for (int i = 1; i < 101; i++)
            {
                if (i % 2 == 0)
                {
                    pares.Append($"\n{i}");
                }
                if (i % 3 == 0)
                {
                    divisiblesPor3.Append($"\n{i}");
                }

            }
            resultado.Append($"Numeros pares:{pares}\nNumeros divisibles por 3:{divisiblesPor3}");
            return resultado.ToString();
        }
    }
}

//10) Recorrer los números del 1 al 100. Crear 2 listas, una con los números pares y otra con los divisibles entre 3. Mostrar las 2 listas.

