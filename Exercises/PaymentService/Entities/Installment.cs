namespace PaymentService.Entities
{
    class Installments
    {
        public DateTime dueData { get; set; }
        public double Amount { get; set; }

        public Installments(DateTime dateTime , double amount)
        {
            dueData=dateTime;
            Amount=amount;

        }
    }
}