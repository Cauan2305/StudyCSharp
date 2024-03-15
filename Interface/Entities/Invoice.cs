using System.Globalization;

namespace Interface.Entities
{
    class Invoice 
    {
        public double  BasicPayment { get; set; }
        public double  Tax { get; set; }

        public Invoice(double rental, double tax)
        {
            BasicPayment=rental;
            Tax=tax;
        }

        public double TotalPayment {
            get {return BasicPayment+Tax;}
        }

        public override string ToString()
        {
            return "Basic Payment: "+
            BasicPayment.ToString("F2",CultureInfo.InvariantCulture)+
            "\nTax: "+
            Tax.ToString("F2",CultureInfo.InvariantCulture)
            +"\n Total Payment: "+
            TotalPayment.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}