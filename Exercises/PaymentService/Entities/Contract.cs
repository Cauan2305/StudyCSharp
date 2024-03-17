using System.Globalization;

namespace PaymentService.Entities
{
    class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }

        public List<Installments> installments=new List<Installments>();

        public Contract(int number , DateTime date,double totalValue)
        {
            Number=number;
            Date=date;
            TotalValue=totalValue;
        }


        public override string ToString()
        {
            string result="Installments: ";
            foreach (Installments i in installments)
            {
                result+=$"\n{i.dueData.ToString("dd/MM/yyyy")} - {i.Amount.ToString("F2",CultureInfo.InvariantCulture)}";
            }
            return result;
        }
    }
}