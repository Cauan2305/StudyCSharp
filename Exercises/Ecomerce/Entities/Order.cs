using Ecomerce.Entities.Enums;
namespace Ecomerce.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public List<OrderItem> Items = new List<OrderItem>();

        public Client Client =new Client();
        


        public Order(){}

        public Order(DateTime moment , OrderStatus status,Client client)
        {
            Moment=moment;
            Status=status;
            Client=client;

        }


        public void AddItem(OrderItem item)
        {
            Items.Add(item);

        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
            
        }

        public double Total()
        {   
            double total=0;
            foreach (OrderItem item in Items)
            {
                    total+=item.SubTotal();
            }
            return total;
        }

        
        public override string ToString()
        {
            string result=$"Order Summary:\nOrder Moment : {Moment.ToString("dd/MM/yyyy hh:mm:ss")}\nOrder Status: {Status}\nClient: {Client}\nOrder Items:";

            foreach (OrderItem i in Items)
            {
                result+=i+"\n";
            }
            result+=$"Total Price: {Total()}";
            return result;
        }
    }
}