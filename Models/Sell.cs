namespace PizzaMaze.Models
{
    public class Sell
    {
        public int Sell_ID { get; set; }
        public string Pizza_name { get; set; }
        public string Topping1 { get; set; }
        public string Topping2 { get; set; }
        public string Topping3 { get; set; }
        public double Price { get; set; }
        public int count { get; set; }
        public int Order_ID { get; set; }
        public int Total { get; set; }
    }
}
