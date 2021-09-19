using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestEnviroment.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ArrayController : ControllerBase
    {
        //[HttpGet]     //ctrl+k+c ir pazymeta visa teksta uzkomentuoja
        //public IActionResult TryArrays()
        //{
        //    //string[] names1 = {"Jonas", "Onute", "Petras" };//pirmas budas
        //    //string[] names2 = new string[3];//antras budas
        //    //names2[0] = "Jonas";
        //    //names2[1] = "Onute";
        //    //names2[2] = "Petras";

        //    int[] ages = new int[5];
        //    ages[0] = 45;
        //    ages[1] = 36;
        //    //ages[2] = sita kai praleidi tai nustato kaip 0
        //    ages[3] = 18;
        //    ages[4] = 20;
        //    double sum = ages[0] + ages[1] + ages[2] + ages[3] + ages[4];
        //    double avarage = /*(double) galima ir taip konvertuoti*/sum / ages.Length;//arba rasai tiesiog 5

        //    return new OkObjectResult(avarage);
        //}

        [HttpPost]
        public IActionResult CalculateAvarage(int[] ages)
        {
            double sum = 0;
            for (int i = 0; i < ages.Length; i++)
            {
                sum += ages[i];
            }

            double avarage = sum / ages.Length;
            
            return new OkObjectResult(avarage);
        }

    }
}
