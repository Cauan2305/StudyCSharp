namespace Sopreposicao.Entities
{
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
        // e Use a palavra override , para sobescrever o metodo
        public override void Withdraw(double amount)
        {
            // Usando o Base ele vai rodar o metodo da superclasse 
            base.Withdraw(amount);
            Balance-=2.0;
        }
    }
}