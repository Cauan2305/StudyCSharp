namespace Heranca.Entities
{
    class BussinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BussinessAccount(){}
        // Em vez de fazer assim 
        // public BussinessAccount(int number,string holder, double balance ,double loanLimit)
        // {
        //     Number=number;
        //     Holder=holder;
        //     Balance=balance;
        //     LoanLimit=loanLimit;

        // }
        // Faça Assim
        public BussinessAccount(double loanLimit,int number,string holder, double balance)
            :base(number,holder,balance)
        {
            LoanLimit=loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance+=amount;
            }
        }
    }
}