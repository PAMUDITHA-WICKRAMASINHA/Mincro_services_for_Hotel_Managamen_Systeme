using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;
using Sliit.MTIT.Employee.Services;
using Sliit.MTIT.Employee.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sliit.MTIT.Employee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmloyeeService _emloyeeService;

        public EmployeeController(IEmloyeeService emloyeeService)
        {
            _emloyeeService = emloyeeService??throw new ArgumentNullException(nameof(emloyeeService));
        }


        /// <summary>
        /// Get all employee
        /// </summary>
        /// <returns>return the list of employee</returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_emloyeeService.GetEmployees());
        }


        /// <summary>
        /// Get employee by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Return the employee with the passed ID</returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return _emloyeeService.GetEmployee(id) != null ? Ok(_emloyeeService.GetEmployee(id)) : NoContent();
        }

        /// <summary>
        /// Add employee
        /// </summary>
        /// <param name="employee"></param>
        /// <returns>Return the added employee</returns>
        [HttpPost]
        public IActionResult Post([FromBody] Models.Employee employee)
        {
            return Ok(_emloyeeService.AddEmployee(employee));
        }

        /// <summary>
        /// Update the employee
        /// </summary>
        /// <param name="employee"></param>
        /// <returns>Return the updated employee</returns>
        [HttpPut]
        public IActionResult Put([FromBody] Models.Employee employee)
        {
            return Ok(_emloyeeService.UpdateEmployee(employee));
        }

        /// <summary>
        /// Delete the employee with the passed ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _emloyeeService.DeleteEmployee(id);

            return result.HasValue & result == true ? Ok($"student with ID:{id} got deleted successfully.")
                : BadRequest($"Unable to delete the student with ID:{id}.");
        }
    }
}
