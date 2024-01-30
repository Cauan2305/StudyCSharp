using System.Globalization;

namespace BankingClassExercise
{
    class Bank
    {
        static private double  _tax = 5.00;
        public int AccountNumber {get; private set;}
        private string Name;

        public double Balance {get;private set;} 
        
        public Bank(string name,int accountNumber)
        {
            Name=name;
            AccountNumber=accountNumber;
        }
        // Sobrecarga 
        public Bank(string name,int accountNumber, double balance):this(name,accountNumber)
        {
            Balance=balance;
        }

        public override string ToString()
        {
            return $"Dados da conta:\nConta {AccountNumber}, Titular: {Name}, Saldo: $ {Balance.ToString("F2",CultureInfo.InvariantCulture)}";
        }

        public void Deposit(double value){
            Balance+=value;
        }

        public void WithDrawal(double value){

            Balance-=(_tax+value);

        }
    }
}