namespace EmployeeCalculatorSalary.Entities
{
    class OutSourcedEmployee: Employee
    {
        public double additionalCharge { get; set; }

        public OutSourcedEmployee(){}

        public OutSourcedEmployee(double additionalCharge,string name,int hours, double valuePerHour):base(name,hours,valuePerHour)
        {
            this.additionalCharge=additionalCharge;
        }


        public override double Payment()
        {   
            double additionalChargePercentage=additionalCharge*110/100;
            return additionalChargePercentage+base.Payment();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}