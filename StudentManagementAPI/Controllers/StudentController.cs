namespace WebApplication1.Controllers;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using System.Linq;

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
    
    
    
    //  Add 
    [HttpPost]
    public IActionResult AddStudent(Student s)
    {
        context.Students.Add(s);
        context.SaveChanges();
        return Ok(s);
    }
    
    
    //  DELETE request to remove a student
    [HttpDelete("{id}")]
    public IActionResult RemoveStudent(int id)
    {
        Student s = context.Students.FirstOrDefault(s => s.StudentId == id);

        if (s == null)
        {
            return NotFound("Student not found.");
        }
        else
        {
            context.Students.Remove(s);
            context.SaveChanges();
            return Ok("Student deleted successfully.");
        }
    }
    
    
    // Get student by ID
    [HttpGet("{id}")]
    public Student GetStudent(int id)
    {
        Student s = context.Students.FirstOrDefault(s => s.StudentId == id);

        return s;
    }
 
    // Get all students
    [HttpGet]
    public List<Student> GetAllStudents()
    {
        List<Student> students = context.Students.ToList();

        return students;
    }
    
    
    // Update student information
    [HttpPut("{id}")]
    public IActionResult UpdateStudent(int id, Student updatedStudent)
    {
        Student s = context.Students.FirstOrDefault(s => s.StudentId == id);

        if (s == null)
        {
            return NotFound("Student not found.");
        }

        s.StudentName = updatedStudent.StudentName;
        s.Age = updatedStudent.Age;
        s.Email = updatedStudent.Email;
        s.Phone = updatedStudent.Phone;
        s.DepartmentId = updatedStudent.DepartmentId;

        context.SaveChanges();

        return Ok(s);
    }
    
    
    
    
}