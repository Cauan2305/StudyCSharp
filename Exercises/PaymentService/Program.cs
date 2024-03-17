using System.Globalization;
using PaymentService.Entities;
using PaymentService.Services;

namespace PaymentService{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");

            Console.Write("Number: ");
            int number= int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date= DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",CultureInfo.InvariantCulture);
            
            Console.Write("Contract Value: ");
            double totalValue = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Contract contractData= new Contract(number,date,totalValue);
            ContractService contractService = new ContractService(new PaypalService());
            
            Console.Write("Enter number of installments: ");
            int numberInstallments=int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            contractService.processContract(contract:contractData,months:numberInstallments);
            Console.Write(contractData);
        }
    }
}