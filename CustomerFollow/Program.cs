using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerId = 10;
            customer1.CustomerFirstName = "elçin";
            customer1.CustomerLastName = "sevim";
            customer1.TelephoneNumber = 5308994254;

            Customer customer2 = new Customer();
            customer2.CustomerId = 18;
            customer2.CustomerFirstName = "ayşe";
            customer2.CustomerLastName = "çakmak";
            customer2.TelephoneNumber = 5458559894;

            Customer customer3 = new Customer();
            customer3.CustomerId = 19;
            customer3.CustomerFirstName = "gülçin";
            customer3.CustomerLastName = "sevim";
            customer3.TelephoneNumber = 5388998258;

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            CustomerManager customerManager = new CustomerManager();
            customerManager.AddCustomer(customer1); //for example is add
            customerManager.DeleteCustomer(customer2); //for example is delete
            customerManager.UpdateCustomer(customer3); //for example is update

            Console.ReadLine();

        }
        
      
    }
}
