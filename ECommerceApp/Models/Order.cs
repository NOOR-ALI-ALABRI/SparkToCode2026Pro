namespace ECommerceApp.Models;

public class Order
{
    public int OrderId { get; set; }
    public DateTime OrderDate { get; set; }
    
    // Foreign Key
    public int UserId { get; set; }
    
    
    // One Order belongs to one User (N:1)
    public User User { get; set; }
}