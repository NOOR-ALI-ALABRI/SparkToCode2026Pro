using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models;

public class Student
{
    [Key]
   
    public int StudentId { get; set; }

    public string StudentName { get; set; }

    public int Age { get; set; }

    public string Email { get; set; }

    public string Phone { get; set; }

    
    // Foreign Key
    public int DepartmentId { get; set; }

    // Navigation Property
    public Department Department { get; set; }
}