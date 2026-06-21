namespace DependencyInjectionExample
{
    public class CustomerService
    {
        private ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public string GetCustomer(int id)
        {
            return _customerRepository.FindCustomerById(id);
        }
    }
}
