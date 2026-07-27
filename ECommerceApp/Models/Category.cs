namespace ECommerceApp.Models;

public class Category
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
    
    
    // One Category can have many Products (1:N)
    public List<Product> Products { get; set; }
    
}