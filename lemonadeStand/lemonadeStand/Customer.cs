using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    public class Customer
    {
        Random rand = new Random();
        int customerMood;
        int willingToSpend;
        public int cash = 10;
        public Customer(int CustomerMood, int WillingToSpend)
        {
            customerMood = CustomerMood;
            willingToSpend = WillingToSpend;

        }

        public int getCustomerMood()
        {
            int customerMoodVariable = rand.Next(0, 4);
            return customerMoodVariable;
        }

        public int getCustomerWilingToSpend()
        {
            int willingToSpendVariable = rand.Next(0, 4);
            return willingToSpendVariable;
        }

        
        public List<Customer> CreateCustomers (int numberOfCustomers)
        {
            Random rand = new Random();
            List<Customer> customers = new List<Customer>();
            for(int i =0; i<numberOfCustomers; i++)
            {
                Customer customer = new Customer(rand.Next(1, 3), (rand.Next(1, 3)));
                customers.Add(customer);
                
            }
            return customers;
            
        }
        





    }
}
