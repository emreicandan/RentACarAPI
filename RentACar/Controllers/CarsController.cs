using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RentACar.Entities;
using RentACar.Repositories.Abstract;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RentACar.Controllers
{
    [Route("api/[controller]")]
    public class CarsController : Controller
    {
        ICarRepository _carRepository;

        public CarsController (ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_carRepository.GetAll());
        }

        [HttpGet("GetBy{id}")]
        public IActionResult Get(Guid id)
        {
            return Ok(_carRepository.Get(car => car.Id==id));
        }


        [HttpPost("Add")]
        public IActionResult Add([FromBody]Car car)
        {
            return Ok(_carRepository.Add(car));
        }


        [HttpPut("Update")]
        public IActionResult Update( [FromBody]Car car)
        {
            return Ok(_carRepository.Update(car));
        }

        [HttpDelete("DeleteBy{id}")]
        public IActionResult Delete(Guid id)
        {
            var car=_carRepository.Get(car => car.Id == id);
            if (car == null)
                return BadRequest("Car not found");
            return Ok(_carRepository.Delete(car));
        }
    }
}

