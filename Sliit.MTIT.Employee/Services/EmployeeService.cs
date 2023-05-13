using Sliit.MTIT.Employee.Data;
using Sliit.MTIT.Employee.Models;

namespace Sliit.MTIT.Employee.Services
{
    public class EmployeeService : IEmloyeeService
    {
        public List<Models.Employee> GetEmployees()
        {
            return EmployeeMockDataService.Employees;
        }
        public Models.Employee? GetEmployee(int id)
        {
            return EmployeeMockDataService.Employees.FirstOrDefault(x => x.Id == id);
        }

        public Models.Employee? AddEmployee(Models.Employee employee)
        {
            EmployeeMockDataService.Employees.Add(employee);
            return employee;
        }
        public Models.Employee? UpdateEmployee(Models.Employee employee)
        {
            Models.Employee slelectEmployee = EmployeeMockDataService.Employees.FirstOrDefault(x => x.Id == employee.Id);
            if (slelectEmployee != null)
            {
                slelectEmployee.Name = employee.Name;
                slelectEmployee.Address = employee.Address;
                slelectEmployee.Email = employee.Email;
                slelectEmployee.Mobile = employee.Mobile;
                return slelectEmployee;
            }

            return slelectEmployee;
        }

        public bool? DeleteEmployee(int id)
        {
            Models.Employee slelectEmployee = EmployeeMockDataService.Employees.FirstOrDefault(x => x.Id == id);
            if (slelectEmployee != null)
            {
                EmployeeMockDataService.Employees.Remove(slelectEmployee);
                return true;
            }

            return false;
        }
    }
}
