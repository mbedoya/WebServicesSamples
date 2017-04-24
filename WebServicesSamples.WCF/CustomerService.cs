using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebServicesSamples.WCF.DataMembers;

namespace WebServicesSamples.WCF
{
    public class CustomerService : CustomerServiceContract
    {
        public List<Customer> GetCustomers()
        {
            var customers = new List<Customer>();
            customers.Add(new Customer() { ID = 1, Email = "john.smith@hotmail.com", Name = "John Smith" });
            customers.Add(new Customer() { ID = 1, Email = "sara.vayner@hotmail.com", Name = "Sara Vayner" });

            return customers;
        }
    }
}
