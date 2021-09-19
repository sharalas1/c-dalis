using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestEnviroment.Controllers
{//kad nebuttu api/ galima cia istrinti ir bus tsg Users
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {//metodas
        [HttpGet]
        public IActionResult GetConnectedUser(string name, string surname)
        {
            return new OkObjectResult(name + surname);
        }
    }
}
