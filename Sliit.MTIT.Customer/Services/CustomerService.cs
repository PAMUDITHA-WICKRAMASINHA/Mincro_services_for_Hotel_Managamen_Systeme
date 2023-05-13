using Sliit.MTIT.Customer.Data;
using Sliit.MTIT.Customer.Models;

namespace Sliit.MTIT.Customer.Services
{
    public class CustomerService : ICustomerService
    {
        public List<Models.Customer> GetCustomers()
        {
            return CustomerMockDataService.Customers;
        }
        public Models.Customer? GetCustomer(int id)
        {
            return CustomerMockDataService.Customers.FirstOrDefault(x => x.Id == id);
        }

        public Models.Customer? AddCustomer(Models.Customer customer)
        {
            CustomerMockDataService.Customers.Add(customer);
            return customer;
        }
        public Models.Customer? UpdateCustomer(Models.Customer employee)
        {
            Models.Customer slelectEmployee = CustomerMockDataService.Customers.FirstOrDefault(x => x.Id == employee.Id);
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

        public bool? DeleteCustomer(int id)
        {
            Models.Customer slelectEmployee = CustomerMockDataService.Customers.FirstOrDefault(x => x.Id == id);
            if (slelectEmployee != null)
            {
                CustomerMockDataService.Customers.Remove(slelectEmployee);
                return true;
            }

            return false;
        }
    }
}
