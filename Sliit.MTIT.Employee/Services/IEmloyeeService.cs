namespace Sliit.MTIT.Employee.Services
{
    public interface IEmloyeeService
    {
        List<Models.Employee> GetEmployees();
        Models.Employee? GetEmployee(int id);
        Models.Employee? AddEmployee(Models.Employee employee);
        Models.Employee? UpdateEmployee(Models.Employee employee);
        bool? DeleteEmployee(int id);
    }
}
