using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnBoarding.Models;
using OnBoarding.Services;

namespace OnBoarding.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SignupController : ControllerBase
    {
        private ICredentialsService _service;
        public SignupController(ICredentialsService service)
        {
            _service = service;
        }
        // GET: api/Customer_Signup
        [HttpGet]
        public IEnumerable<Customer> GetCustomer()
        {
            return _service.GetAllSignUp();
        }
        // GET: api/Customer_Signup/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCustomer([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Customer customer = await _service.GetSignUp(id);
            if (customer == null)
            {
                return NotFound();
            }
            return Ok(customer);
        }

        // POST: api/Customer_Signup
        [HttpPost]
        public async Task<IActionResult> PostCustomer([FromBody] Customer customer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _service.CreateCredentials(customer);
            return CreatedAtAction("GetCustomer", new { id = customer.Id }, customer);
        }
    }
}