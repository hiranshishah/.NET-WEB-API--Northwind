using API1.Model;

namespace API1.Repository.interfaces
{
    public interface ICustomerRepo
    {
       List<string> GetCustomer();
       Customer GetCustomerById(string id);
        void AddCustomer(Customer customer);
        void UpdateCustomer(string id, Customer customer);
        void DeleteCustomer(string id);
    }
}
