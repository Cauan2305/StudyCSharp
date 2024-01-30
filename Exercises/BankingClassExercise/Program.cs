
namespace BankingClassExercise
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Write("Entre o número da conta:");
            int accountNumber = int.Parse(Console.ReadLine());

            Console.Write("Entre o Titular da conta:");
            string? name = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)?");
            Bank b= new Bank(name,accountNumber);
            
            string? checkDeposit =Console.ReadLine();

            if (checkDeposit != null && checkDeposit.ToLower() == "s")
            {
                Console.Write("Entre o valor de depósito inicial:");
                double Initialdeposit=double.Parse(Console.ReadLine());
                b.Deposit(Initialdeposit);

            }
            Console.WriteLine(b);

            Console.Write("Entre um valor para depósito: ");
            double deposit = double.Parse(Console.ReadLine());
            b.Deposit(deposit);

            Console.WriteLine(b);


            Console.Write("Entre um valor para saque: ");
            double withDrawal = double.Parse(Console.ReadLine());
            b.WithDrawal(withDrawal);
            Console.WriteLine(b);


        }
    }
}