namespace Sliit.MTIT.Customer.Services
{
    public interface ICustomerService
    {
        List<Models.Customer> GetCustomers();
        Models.Customer? GetCustomer(int id);
        Models.Customer? AddCustomer(Models.Customer Customer);
        Models.Customer? UpdateCustomer(Models.Customer Customer);
        bool? DeleteCustomer(int id);
    }
}
