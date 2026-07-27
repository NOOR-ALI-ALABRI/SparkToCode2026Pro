namespace ECommerceApp.Models;

public class OrderProduct
{
    
    // Many-to-Many relationship between Order and Product
    public int Quantity { get; set; }
    
    public int OrderId { get; set; }  // FK → Order
    public int ProductId { get; set; } // FK → Product
    
    
    public Order Order { get; set; }
    public Product Product { get; set; }
    
}