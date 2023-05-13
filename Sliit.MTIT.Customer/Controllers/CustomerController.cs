using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;
using Sliit.MTIT.Customer.Services;
using Sliit.MTIT.Customer.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sliit.MTIT.Customer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService ?? throw new ArgumentNullException(nameof(customerService));
        }

        /// <summary>
        /// Get all customer
        /// </summary>
        /// <returns>return the list of customer</returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_customerService.GetCustomers());
        }

        /// <summary>
        /// Get customer by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Return the customer with the passed ID</returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return _customerService.GetCustomer(id) != null ? Ok(_customerService.GetCustomer(id)) : NoContent();
        }

        /// <summary>
        /// Add customer
        /// </summary>
        /// <param name="customer"></param>
        /// <returns>Return the added customer</returns>
        [HttpPost]
        public IActionResult Post([FromBody] Models.Customer customer)
        {
            return Ok(_customerService.AddCustomer(customer));
        }

        /// <summary>
        /// Update the customer
        /// </summary>
        /// <param name="customer"></param>
        /// <returns>Return the updated customer</returns>
        [HttpPut]
        public IActionResult Put([FromBody] Models.Customer customer)
        {
            return Ok(_customerService.UpdateCustomer(customer));
        }

        /// <summary>
        /// Delete the customer with the passed ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _customerService.DeleteCustomer(id);

            return result.HasValue & result == true ? Ok($"student with ID:{id} got deleted successfully.")
                : BadRequest($"Unable to delete the student with ID:{id}.");
        }
    }
}
