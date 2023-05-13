using System.Reflection;

namespace Sliit.MTIT.Customer.Data
{
    public class CustomerMockDataService
    {
        public static List<Models.Customer> Customers = new List<Models.Customer>()
        {
            new Models.Customer{Id = 1, Name = "Pamuditha", Address = "Chilaw", Email = "pamuditha@gmail.com", Mobile = 0715487963},
        };
    }
}
