using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using product;


namespace trainingOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();
            p.display();
            Customer c = new Customer();
            Console.ReadLine();

        }
    }
}
