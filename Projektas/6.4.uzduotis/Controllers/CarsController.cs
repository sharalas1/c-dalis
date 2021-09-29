using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace projektas
{
    [Route("[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        [HttpPost]
        public IActionResult Create(Car car)
        {
            if(car.Name == "")
            {
                return ValidationProblem("Nenurodete vardo!");
            }

            if(car.Price == 0)
            {
                return ValidationProblem("Nenurodete kainos!");
            }
           
            if(car.CarDate == 0)
            {
                return ValidationProblem("Nenurodete metu!");
            }

            var service = new CarService();
            service.CreateCar(car);
            
            return Ok();
        }
        [HttpGet("list")]
        public IActionResult List()
        {
            var service = new CarService();
            var cars = service.GetCars();
            return new OkObjectResult(cars);
        }

        [HttpGet]
        public IActionResult Get(string documentId)
        {
            var service = new CarService();
            var cars = service.GetCars(documentId);
            return new OkObjectResult(cars);
        }

        [HttpGet("filter")]
        public IActionResult Filter(string text)
        {
            var service = new CarService();
            var cars = service.GetCars();

            var filteredCars = new List<Car>();
            foreach (var car in cars)
            {
                if (car.GetInformation().Contains(text))
                {
                    filteredCars.Add(car);
                }
            }
            return new OkObjectResult(filteredCars);
        }
    }
}
