using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
   public class CustomerManager
    {
       public void AddCustomer(Customer customer)
        {
            Console.WriteLine("Added Customer : " + " " + customer.CustomerId + " :" + customer.CustomerFirstName + " :" + customer.TelephoneNumber);
        }
        public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine("Delete Customer :" + "" + customer.CustomerId + " :" + customer.CustomerFirstName + " :" + customer.TelephoneNumber);
        }
        public void UpdateCustomer(Customer customers)
        {
            Console.WriteLine("Update by Customer :" + "" + customers.CustomerId + " :" + customers.CustomerFirstName + " :" + customers.TelephoneNumber);
        }
    }


}
