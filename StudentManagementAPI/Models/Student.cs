using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models;

public class Student
{
    [Key]
    public int DepartmentId { get; set; }

    public string DepartmentName { get; set; }

    public string Location { get; set; }
}