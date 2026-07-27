namespace ECommerceApp.Models;

public class User
{
    public int UserId { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    // One User can have many Orders (1:N) places
    public List<Order> Orders { get; set; } 
    
}