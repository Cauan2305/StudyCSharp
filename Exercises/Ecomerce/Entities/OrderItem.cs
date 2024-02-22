namespace Ecomerce.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }

        public Product Product;

        public OrderItem(){}

        public OrderItem(Product product ,int quantity, double price)
        {
            Quantity=quantity;
            Price=price;
            Product=product;
        }
        
        public double SubTotal()
        {
            return Price*Quantity;
        }

        public override string ToString()
        {
            return $"\n{Product},SubTotal : {SubTotal()}";
        }
    }    
}