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
    public class ForLoop : ControllerBase
    {
        /*[HttpGet]
        public IActionResult FirstExample()
        {
            string line = "";

            for(int i = 0; i < 10; i++)//startuojam nuo i, antra dalis suksis iki tol kol true
            {
                if(i % 2 == 0)//modaline dalyba kai grazinama liekana t.y. kas du simbolius
                {
                    line += i + "\n";//  "\n" simbolis reiskia nauja eilute
                }
            }

            return new OkObjectResult(line);//iskarto pasidarai su tusciom ""
        }*/


        [HttpGet]
        public IActionResult SecondExample()
        {
            string result = "";

            for(int i = 0; i < 20; i++)
            {
                if(i % 3 == 0)// kas tris simbolius
                {
                    result += i + ", ";
                }
            }
            result = result.Remove(result.Length - 2, 2);//pasalinam paskutini simboli t.y. ,
            return new OkObjectResult(result);
        }
    }
}
