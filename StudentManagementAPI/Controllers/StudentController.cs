namespace WebApplication1.Controllers;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

[ApiController]
[Route ("")]
public class StudentController : ControllerBase
{
    //to access the database
    private UniversityContext context;
    public StudentController(UniversityContext _context)
    {
        context = _context;
    }
    
    [HttpPost]
    public IActionResult AddStudent(Student s)
    {
        context.Students.Add(s);
        context.SaveChanges();
        return Ok(s);
    }
    
    
    
    //  DELETE request to remove a student
    public void RemoveStudent(int id)
    {
        Student s = context.Students.FirstOrDefault(s => s.StudentId == id);

        if (s == null)
        {
            Console.WriteLine("Student not found.");
        }
        else
        {
            context.Students.Remove(s);
            context.SaveChanges();
            Console.WriteLine("Student deleted successfully.");
        }
    }


    
    
    
}