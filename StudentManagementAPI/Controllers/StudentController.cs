namespace WebApplication1.Controllers;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route ("")]
public class StudentController : ControllerBase
{
    //to access the database
    private UniversityContext _context;
    public StudentController(UniversityContext context)
    {
        _context = context;
    }


    
    
    
}