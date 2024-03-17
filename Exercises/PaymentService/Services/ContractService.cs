using PaymentService.Entities;

namespace PaymentService.Services
{
    class ContractService
    {
        private  IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService=onlinePaymentService;
        }


        public void processContract(Contract contract,int months){
            double basicQuota =contract.TotalValue/months;
            for (int i =1;i<=months ; i++)
            {
                DateTime date= contract.Date.AddMonths(i);
                double interest =basicQuota+_onlinePaymentService.Interest(amount:basicQuota,i);
                double fullQuota  =interest+_onlinePaymentService.PaymentFee(amount:interest);

                Installments installments= new Installments(date,fullQuota);
                contract.installments.Add(installments);

            }
            


        }
    }
}