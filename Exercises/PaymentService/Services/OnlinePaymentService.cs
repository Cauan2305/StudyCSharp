namespace PaymentService.Services
{
    interface IOnlinePaymentService
    {
        public double PaymentFee(double amount);

        public double Interest (double amount , double months);
    }
}