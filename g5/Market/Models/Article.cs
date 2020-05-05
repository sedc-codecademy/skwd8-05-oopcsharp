namespace Models
{
    public class Article
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public int Price { get; set; }

        public Article(string name, int stock, int price)
        {
            Name = name;
            Stock = stock;
            Price = price;
        }
    }
}
