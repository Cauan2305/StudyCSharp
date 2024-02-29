namespace ClasseSelada.Entities
{  
    // Selando a classe para que ela nao possa ser sobreposta
    // sealed class SavingsAccount : Account
    class SavingsAccount : Account

    {
        public double InterestRate { get; set; }

        public SavingsAccount(){}
        public SavingsAccount(int number,string holder, double balance,double interestRate)
            :base(number,holder,balance)
        {
            InterestRate=interestRate;
        }

        public void UpdateBalance()
        {
            Balance+=Balance*InterestRate;
        }

        // Agora para selar um metodo 
        // ele precisar estar sobrescrevendo o metodo da superclasse  
        sealed public override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance-=2.0;
        }
    }
}