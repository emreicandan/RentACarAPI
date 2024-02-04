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
    public class CustomersController : Controller
    {

        ICustomerRepository _customerRepository;

        public CustomersController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_customerRepository.GetAll());
        }

        [HttpGet("GetBy{id}")]
        public IActionResult Get(Guid id)
        {
            return Ok(_customerRepository.Get(customer => customer.Id==id));
        }

        [HttpPost("Add")]
        public IActionResult Add([FromBody]Customer customer)
        {
            return Ok(_customerRepository.Add(customer));
        }


        [HttpPut("Update")]
        public IActionResult Update([FromBody]Customer customer)
        {
            return Ok(_customerRepository.Update(customer));
        }


        [HttpDelete("DeleteBy{id}")]
        public IActionResult Delete(Guid id)
        {
            var customer = _customerRepository.Get(customer => customer.Id == id);
            if (customer == null)
                return BadRequest("Customer not found");
            return Ok(_customerRepository.Delete(customer));
        }
    }
}

