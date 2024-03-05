
namespace ProductsInheritance.Entities
{
    class UsedProducts:Product
    {
        public DateTime manufactureDate {get;set;}

        public UsedProducts(){}

        public UsedProducts(DateTime manufactureDate,string name , double price):base(name,price)
        {
            this.manufactureDate=manufactureDate;
        }
        public override string priceTag()
        {
            return $"{Name} (used) ${Price} (Manafacture date : {manufactureDate.ToString("dd/MM/yyyy")})";
        }
    }
}