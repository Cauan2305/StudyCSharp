using Ecomerce.Entities;
using Ecomerce.Entities.Enums;

namespace Ecomerce
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Client Data :");
            
            Console.Write("Name : ");
            string nameClient=Console.ReadLine() ?? "null";

            Console.Write("Email : ");
            string emailClient=Console.ReadLine() ?? "";
            

            Console.Write("Birth Date : ");
            DateTime birthDateClient=DateTime.Parse(Console.ReadLine());

            Client client=new Client(nameClient,emailClient,birthDateClient);
            

            Console.WriteLine("Enter Order Data:");
            Order order = new Order(DateTime.UtcNow,OrderStatus.PROCESSING,client);
            
            // Console.WriteLine($"Status : ");
            // string status = Console.ReadLine() ?? "Processing";

            Console.WriteLine("How Many Items to This Order ? ");
            int totalItems = int.Parse(Console.ReadLine());
            Product product;
            for (int i=0 ; i<totalItems;i++)
            {
                Console.WriteLine($"Enter #{i+1} Item Data : ");
                
                Console.Write("Product Name : ");
                string productName = Console.ReadLine();

                Console.Write("Product Price : ");
                double productPrice = double.Parse(Console.ReadLine());


                Console.Write("Quantity : ");
                int quantity = int.Parse(Console.ReadLine());
                
                product = new Product(productName??"",productPrice);
                OrderItem item = new OrderItem(product,quantity,productPrice);
                order.AddItem(item);
                                
            }
            Console.WriteLine("");
            Console.WriteLine("-------------------");
            Console.WriteLine(order);
        }
    }   
}