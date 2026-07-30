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
    
    


    
    
    
}