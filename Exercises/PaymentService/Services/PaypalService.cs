
namespace PaymentService.Services
{
    class PaypalService : IOnlinePaymentService
    {
        private const double feePercentage =0.02;
        private const double MonthlyInterest =0.01;

        public double Interest(double amount, double months)
        {
            return amount*MonthlyInterest*months;
        }

        public double PaymentFee(double amount)
        {   
            return amount*feePercentage;
        }
    }
}