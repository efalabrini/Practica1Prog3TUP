using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Ej9Controller : ControllerBase
    {
        [HttpGet()]
        public List<int> Get()
        {
            List<int> lista = new List<int>();

            for (int i = 0; i <= 100; i++)
            {
                if(i%2 == 0)
                {
                    lista.Add(i);
                }
            }
            return lista;
        }
    }
}
