namespace PizzaMaze.Models
{
  public class Orders
  {
      public int Order_ID { get; set; }
      public string Customer_name { get; set; }
      public DateTime Order_Date { get; set; }
      public string Pizza_name { get; set; }
      public string Topping1 { get; set; }
      public string Topping2 { get; set; }
      public string Topping3 { get; set; }
      public int count { get; set; }
  }  
}

