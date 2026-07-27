namespace ECommerceApp.Models;

public class Order
{
    public int OrderId { get; set; }
    public DateTime OrderDate { get; set; }
    
    // Foreign Key
    public int UserId { get; set; }
    
    // One Order belongs to one User (N:1)
    public User User { get; set; }
    
    // Many-to-Many through OrderProduct
    public List<OrderProduct> OrderProducts { get; set; }
    
    // One Order has one Review (1:1)
    public Review Review { get; set; }
}