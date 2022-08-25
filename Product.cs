using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product
{
    public class Product
    {
        public int productId { get; set; }
        public string productName { get; set; }
        public string productCost { get; set; }

        public Product()
        {
            Console.WriteLine("Enter your ProductId");
            productId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your ProductName");
            productName = Console.ReadLine();
            Console.WriteLine("Enter your ProductCost");
            productCost = Console.ReadLine();
        }

        public void display()
        {
            Console.WriteLine("ProductId is" + productId);
            Console.WriteLine("ProductName is" + productName);
            Console.WriteLine("ProductCost is" + productCost);

        }
    }
}
