using API1.Model;
using API1.Repository;
using API1.Repository.interfaces;
using API1.services.interfaces;

namespace API1.services
{
    public class CustomerServiceImpl : ICustomerService
    {
        ICustomerRepo _customerRepo;
        public CustomerServiceImpl(ICustomerRepo customerRepo)
        {
            _customerRepo = customerRepo;
            
        }
        public Customer GetCustomerById(string id)
        {
            return _customerRepo.GetCustomerById(id);
        }

        public List<string> GetCustomer()
        {
            throw new NotImplementedException();
        }
        public void AddCustomer(Customer customer)
        {
            _customerRepo.AddCustomer(customer);
        }

        public void UpdateCustomer(string id, Customer customer)
        {
            _customerRepo.UpdateCustomer(id, customer);
        }

        public void DeleteCustomer(string id)
        {
            _customerRepo.DeleteCustomer(id);
        }
    }
}
