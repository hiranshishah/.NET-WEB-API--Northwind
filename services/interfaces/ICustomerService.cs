using API1.Model;

namespace API1.services.interfaces
{
    public interface ICustomerService
    {
        List<string> GetCustomer();
        Customer GetCustomerById(string id);
        void AddCustomer(Customer customer);
        void UpdateCustomer(string id, Customer customer);
        void DeleteCustomer(string id);
    }
}
