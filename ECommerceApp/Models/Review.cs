namespace ECommerceApp.Models;

public class Review
{
    public int ReviewId { get; set; }
    public int Rating { get; set; }
    public string Comment { get; set; }

    
    // Foreign Key
    public int OrderId { get; set; }
    
    // One Review belongs to one Order (1:1)
    public Order Order { get; set; }

}