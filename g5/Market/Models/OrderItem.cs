namespace Models
{
    public class OrderItem
    {
        public Article Article { get; set; }
        public int Quantity { get; set; }

        public OrderItem(Article article, int quantity)
        {
            Article = article;
            Quantity = quantity;
        }

        public int CalculatePrice()
        {
            return Article.Price * Quantity;
        }

        public string GetOrderItemInfo()
        {
            return $"{Article.Name} x {Quantity} = {CalculatePrice()}";
        }
    }
}
