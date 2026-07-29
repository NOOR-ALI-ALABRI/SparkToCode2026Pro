using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace WebApplication1.Models;

public class Department
{
    [Key]
    [JsonIgnore]
    public int DepartmentId { get; set; }
    
    [Required]
    public string DepartmentName { get; set; }
    
    [Required]
    public string Location { get; set; }

    
    // Navigation Property
    [JsonIgnore]
    public List<Student> Students { get; set; }
}