using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models;

public class Department
{
    [Key]
    public int StudentId { get; set; }

    public string StudentName { get; set; }

    public int Age { get; set; }

    public string Email { get; set; }

    public string Phone { get; set; }

}