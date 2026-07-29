using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models;

public class Department
{
    [Key]
    public int DepartmentId { get; set; }

    public string DepartmentName { get; set; }

    public string Location { get; set; }

    
    // Navigation Property
    public List<Student> Students { get; set; }
}