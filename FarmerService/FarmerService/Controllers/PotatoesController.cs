using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmerService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PotatoesController : ControllerBase
    {
        [HttpPost]
        public IActionResult CalculateResults(int[] potatoes)
        {
            string message = "";

            // sum skaiciavimas
            int sum = 0;
            for (int i = 0; i < potatoes.Length; i++) //identiskas visada tik pavadinima pakeiti
            {
                sum += potatoes[i];
            }
            message += "Is viso bulviu buvo parduota " + sum + " kg.";

            // vidurkio skaiciavimas
            var average = (double)sum / potatoes.Length;
            message += $"Vieno ukininko parduotu bulviu vidurkis yra {average} kg";

            //suskaiciuoti tuos kurie pardave daugiau nei 50kg bulviu
            int counter = 0;
            for (int i = 0; i < potatoes.Length; i++)
            {
                if(potatoes[i] > 50)
                {
                    counter++;
                }
            }
            message += $"Ukininku, kurie pardave daugiau nei 50kg yra {counter}";

                return new OkObjectResult(message);
        }
    }
}
