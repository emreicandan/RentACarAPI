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
    public class RentsController : Controller
    {
        IRentRepository _rentRepository;
        public RentsController(IRentRepository rentRepository)
        {
            _rentRepository = rentRepository;
        }
        

        [HttpGet ("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_rentRepository.GetAll());
        }

        // GET api/values/5
        [HttpGet("GetBy{id}")]
        public IActionResult Get(Guid id)
        {
            return Ok(_rentRepository.Get(rent => rent.Id == id));
        }

        // POST api/values
        [HttpPost("Add")]
        public IActionResult Add([FromBody] Rent rent)
        {
            return Ok(_rentRepository.Add(rent));
        }

        // PUT api/values/5
        [HttpPut("Update")]
        public IActionResult Update( [FromBody]Rent rent)
        {
            return Ok(_rentRepository.Update(rent));
        }

        // DELETE api/values/5
        [HttpDelete("DeleteBy{id}")]
        public IActionResult Delete(Guid id)
        {
            var rent = _rentRepository.Get(rent => rent.Id == id);
            if (rent == null)
                return BadRequest("Rent is not found");
                return Ok(_rentRepository.Delete(rent));
        }
    }
}

