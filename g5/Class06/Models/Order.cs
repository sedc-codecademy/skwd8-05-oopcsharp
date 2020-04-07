namespace Models
{
    public class Order
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string PizzaName { get; set; }
        public int Price { get; set; }
        public Status Status { get; set; }

        public Order(string name, string phone, string pizzaName, int price, string address)
        {
            Name = name;
            Phone = phone;
            PizzaName = pizzaName;
            Price = price;
            Status = Status.New;
            Address = address;
        }

        public void Delivery()
        {
            Status = Status.Delivered;
        }

        public void Paid()
        {
            Status = Status.Paid;
        }

        public string GetOrderInfo()
        {
            return $"Pizza: {PizzaName} \nOrder by: {Name} ({Phone}) \nPrice: {Price} \nStatus: {Status}\nAddress: {Address}";
        }
    }
}
