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
    public class NameDayController : ControllerBase
    {
        //[HttpGet]
        //public IActionResult GetNameDay(string name)
        //{
        //    string[] names = {
        //        "Rimgaudas",
        //        "Joginte",
        //        "Kamile",
        //        "Edita",
        //        "Eufemija",
        //        "Gediminas",
        //        "Kornelijus" };

        //    string message = "";
        //    for (int i = 0; i < names.Length; i++)
        //    {
        //        if(names[i] == name)
        //        {
        //            // TODO logika kai randu varda masyve
        //            message = $"Sveikiname su vardo diena! {name}!";
        //            break;
        //        }
        //        else
        //        {
        //            // TODO logika kai nerandu vardo masyve
        //            var namesInString = string.Join(",", names);// .Join naudojam kai norim sujungti zodzius 
        //            message = $"Siandien vardo diena svencia: {namesInString}";
        //        }
        //    }

        //    return new OkObjectResult(message);
        //}

        [HttpGet]
        public IActionResult GetNameDay(string name)
        {
            string[] names = {
                "Rimgaudas",
                "Joginte",
                "Kamile",
                "Edita",
                "Eufemija",
                "Gediminas",
                "Kornelijus" };
                                    
            //sutrumpintas if
            //string message = name.Contains(name) 
            //    ? $"Sveikiname su vardo diena! {name}!" 
            //    : $"Siandien vardo diena svencia: {string.Join(",", names)}";
            
            
            string message = "";

            if (names.Contains(name))
            {
                message = $"Sveikiname su vardo diena! {name}!";
            }
            else
            {
                var namesInString = string.Join(",", names);
                message = $"Siandien vardo diena svencia: {namesInString}";
            }

            return new OkObjectResult(message);
        }
      
    }
}
