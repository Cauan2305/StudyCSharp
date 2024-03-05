namespace ProductsInheritance.Entities
{
    class ImportedProducts:Product
    {
        public double customsFee {get;set;}


        public ImportedProducts(){}

        public ImportedProducts(double customsFee,string name , double price):base(name,price)
        {
            this.customsFee=customsFee;
        }

        public override string priceTag()
        {
            return $"{Name} ${Price} (Customs fee : {customsFee})";
        }

        public double totalPrice()
        {
            Price+=customsFee;
            return Price;
        }

    }
}