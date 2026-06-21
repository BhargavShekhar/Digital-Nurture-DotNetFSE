using System;

namespace DependencyInjectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create repository
            ICustomerRepository customerRepository = new CustomerRepository();

            // Inject repository into service
            CustomerService customerService = new CustomerService(customerRepository);

            // Retrieve and display customer information
            string customer1 = customerService.GetCustomer(1);
            Console.WriteLine("Customer ID: 1");
            Console.WriteLine($"Customer Name: {customer1}");

            Console.WriteLine();

            string customer2 = customerService.GetCustomer(2);
            Console.WriteLine("Customer ID: 2");
            Console.WriteLine($"Customer Name: {customer2}");

            Console.WriteLine();

            string customer5 = customerService.GetCustomer(5);
            Console.WriteLine("Customer ID: 5");
            Console.WriteLine($"Customer Name: {customer5}");
        }
    }
}
