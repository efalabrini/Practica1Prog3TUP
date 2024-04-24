using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System;

namespace Proyecto1Programacion3.Controllers
{
    public class Ejercicio_5 : Controller
    {
        public string Get([FromQuery] string day)
        {
            string reply = "Fin de semana";
            day = day.ToLower();
            string[] week = new string[] { "lunes", "martes", "miercoles", "jueves", "viernes", "sabado", "domingo" };

            bool containsDaysWeek = week.Any(days => day.Trim().contains(days, StringComparasion.OrdinalIgnoreCase))
        }
    }
}
