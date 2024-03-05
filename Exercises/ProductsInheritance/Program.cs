using ProductsInheritance.Entities;

namespace ProductsInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter The Number of Products :");
            int numbersProducts = int.Parse(Console.ReadLine());
            List<Product> products = new List<Product>();
            for (int i =1; i<=numbersProducts; i++)
            {
                Console.WriteLine($"Product : #{i} data:");

                Console.Write("Common , used, imported (c/u/i)?");
                char typeProduct = char.Parse(Console.ReadLine());
                
                Console.Write("Name:");
                string Name = Console.ReadLine();

                Console.Write("Price:");
                double Price = double.Parse(Console.ReadLine());
                
                switch (typeProduct)
                {
                    case 'i':
                        Console.Write("Customs fee:");
                        double  CustomsFee= double.Parse(Console.ReadLine());
                        ImportedProducts productImported = new ImportedProducts(CustomsFee,Name,Price);
                        products.Add(productImported);
                        break;
                    case 'u':
                        Console.Write("Manufacture date:");
                        DateTime  ManufactureDate= DateTime.Parse(Console.ReadLine());
                        UsedProducts usedProducts = new UsedProducts(ManufactureDate,Name,Price);
                        products.Add(usedProducts);
                        break;

                    case 'c':
                        Product product = new Product(Name,Price);
                        products.Add(product);
                        break;
                    default:
                        Console.WriteLine("Invalid Type Product");
                        break;
                }
            }
            Console.WriteLine("PRICE TAGS:");
            foreach (Product p in products)
            {   
                Console.WriteLine(p.priceTag());

            }
        }   
    }
}