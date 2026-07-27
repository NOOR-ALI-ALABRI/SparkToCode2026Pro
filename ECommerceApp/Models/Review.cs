namespace ECommerceApp.Models;

public class Review
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public decimal ProductPrice { get; set; }
    
    // Foreign Key
    public int OrderId { get; set; }
    
    // One Review belongs to one Order (1:1)
    public Order Order { get; set; }

}