using API1.Model;
using API1.services.interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("success");
        }
        [HttpGet("{id}")] 
        public IActionResult Get(string id) 
        {
            return Ok(_customerService.GetCustomerById(id));

        }
        [HttpPost]
        public IActionResult AddCustomer([FromBody] Customer customer)
        {
            _customerService.AddCustomer(customer);
            return Ok();
        }

        // PUT api/customer/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateCustomer(string id, [FromBody] Customer customer)
        {
            _customerService.UpdateCustomer(id, customer);
            return Ok();
        }

        // DELETE api/customer/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteCustomer(string id)
        {
            _customerService.DeleteCustomer(id);
            return Ok();
        }


    }
}
