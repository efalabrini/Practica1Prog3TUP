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
            List<int> pares = new List<int>(); // creo listas de enteros
            List<int> divisibles3 = new List<int>();


            for(int x = 0; x <= 100;x++){
                if(x%2 == 0){
                    pares.Add(x); // agrego el numero en esa iteracion
                };

                if(x%3==0){
                    divisibles3.Add(x);
                };
            };

            return $"Pares:{string.Join(", ", pares)} \nDivisibles por 3: {string.Join(", ", divisibles3)}";
    }
}
}

