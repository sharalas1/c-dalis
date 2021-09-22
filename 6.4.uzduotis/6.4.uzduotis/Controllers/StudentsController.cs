using _6._4.uzduotis.Models;
using _6._4.uzduotis.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace _6._4.uzduotis.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        //"name" : "Jonas"
        //"surname" : "Jonaitis"
        //"documentId" : "abb123"
        //"birthDay" : "2000-01-01"
        
        
        [HttpPost]
        public IActionResult Create(Student student)
        {
            if(student.Name == "")
            {
                return ValidationProblem("Nenurodete vardo!");
            }

            if(student.Surname == "")
            {
                return ValidationProblem("Nenurodete pavardes!");
            }
           
            if(student.DocumentId == "")
            {
                return ValidationProblem("Nenurodete dokumento!");
            }
            
            if(student.BirthDay == DateTime.MinValue)
            {
                return ValidationProblem("Nenurodete datos!");
            }
            
            return new OkResult();
        }
        [HttpGet("list")] // irasome pavadinima kad nesidubliuotu
        public IActionResult List()
        {
            var service = new StudentService();
            var students = service.GetStudents();
            return new OkObjectResult(students);
        }

        [HttpGet]
        public IActionResult Get(string documentId)
        {
            var service = new StudentService();
            var studens = service.GetStudents();

            foreach(var student in students)
            {
                if(student.DocumentId == documentId)
                {
                    return new OkObjectResult(student);
                }
            }
            return NotFound();
        }

        [HttpGet("filter")]
        public IActionResult Filter(string text)
        {
            var service = new StudentService();
            var students = new StudentService();

            var filteredStudents = new List<Student>();
            foreach(var student in students)
            {
                if (student.GetInformation().Contains(text))
                {
                    filteredStudents.Add(student);
                }
            }
            return new OkObjectResult(filteredStudents);
        }
    }
}
