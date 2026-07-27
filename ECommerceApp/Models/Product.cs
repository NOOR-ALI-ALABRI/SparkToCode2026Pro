namespace ECommerceApp.Models;

public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public decimal ProductPrice { get; set; }
    
    
    // Foreign Key
    public int CategoryId { get; set; }
    
    
    // One Product belongs to one Category (N:1)
    public Category Category { get; set; }
    
}