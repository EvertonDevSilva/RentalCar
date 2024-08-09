using Microsoft.AspNetCore.Mvc;
using RentalCar.DTOs;
using RentalCar.Interfaces;
using RentalCar.Models;

namespace RentalCar.Controllers.v1
{
    [ApiController]
    [Route("Api/[controller]")]
    public class CarController(ICarService carService) : ControllerBase
    {
        private readonly ICarService _carService = carService;

        [HttpPost]
        public IActionResult Create(CarCreateDto input)
        {
            var car = new Car(input.Brand, input.PlaceId, input.KmInitial);
            return Ok(_carService.Create(car));
        }
        [HttpGet("id")]
        public IActionResult GetById(int id)
        {
            return Ok(_carService.GetById(id));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_carService.GetAll());
        }

        [HttpPut("id")]
        public IActionResult Update(int id, CarUpdateDto input)
        {
            var car = _carService.GetById(id).Result;

            if (car != null)
            {
                car.UpdateCar(input.Brand, input.PlaceId, input.KmInitial, input.KmFinal, input.IsRended);
                return Ok(_carService.Update(car));
            }

            return Ok("Car not found");
        }

        [HttpDelete("id")]
        public IActionResult Delete(int id)
        {
            return Ok(_carService.Delete(id));
        }
    }
}
