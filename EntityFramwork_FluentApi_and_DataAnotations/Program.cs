using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramwork_FluentApi_and_DataAnotations
{
    class Program
    {
        static void Main()
        {
            using (MyShopData db = new MyShopData())
            {
                db.Configuration.LazyLoadingEnabled = false;

                var orders = db.Orders.Include(p => p.Product);

                foreach (var order in orders)
                {
                    Console.WriteLine($"Order Id: {order.Id}");
                    Console.WriteLine($"Customer name: {order.Customer.Name}");
                    Console.WriteLine($"Customer email: {order.Customer.Email}");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                        foreach (var product in order.Product)
                        {
                            Console.WriteLine($"Product name: {product.Name}");
                            Console.WriteLine($"Product name: {product.CompanyName}");
                            Console.WriteLine($"Product name: {product.Coast}");
                        }

                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(new string('-',50));
                    Console.WriteLine();
                }

                Console.ReadKey();
            }
        }
    }
}
