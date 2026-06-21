using System;
using System.Collections.Generic;

namespace DependencyInjectionExample
{
    public class CustomerRepository : ICustomerRepository
    {
        private Dictionary<int, string> _customers;

        public CustomerRepository()
        {
            // Sample customer data
            _customers = new Dictionary<int, string>
            {
                { 1, "John Doe" },
                { 2, "Jane Smith" },
                { 3, "Mike Johnson" },
                { 4, "Sarah Williams" }
            };
        }

        public string FindCustomerById(int id)
        {
            if (_customers.ContainsKey(id))
            {
                return _customers[id];
            }
            return "Customer not found";
        }
    }
}
