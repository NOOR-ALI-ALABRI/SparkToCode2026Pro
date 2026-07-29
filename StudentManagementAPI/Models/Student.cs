using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace WebApplication1.Models;

public class Student
{
    [Key]
   
    [JsonIgnore]
    public int StudentId { get; set; }
    
    [Required]
    public string StudentName { get; set; }
    
    [Required]
    public int Age { get; set; }
    
    [Required]
    public string Email { get; set; }
    
    [Required]
    public string Phone { get; set; }

    
    // Foreign Key
    [JsonIgnore]
    [ForeignKey("Department")]
    public int DepartmentId { get; set; }

    // Navigation Property
    
    [JsonIgnore]
    public Department Department { get; set; }
}