using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


    public class Ej8Controller : ControllerBase
    {
        [HttpGet()]

        public string Get()
        {
            StringBuilder Numbers = new StringBuilder();  // Constructor de cadenas

            int Cont = 0;

            while (Cont <= 99)
            {
                Cont++;
                Numbers.Append($"{Cont} - ");
            }

           
            return Numbers.ToString();


        }
    }
}
