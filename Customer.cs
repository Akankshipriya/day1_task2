using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trainingOOP
{
    class Customer
    {
            public int customerId { get; set; }
            public string customerName { get; set; }

            public Customer()
            {
                Console.WriteLine("Enter your CustomerId");
                customerId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your ProductName");
                customerName = Console.ReadLine();
            }

            public void display()
            {
                Console.WriteLine("CustomerId is" + customerId);
                Console.WriteLine("ProductName is" + customerName);

            }
        
    }
}
