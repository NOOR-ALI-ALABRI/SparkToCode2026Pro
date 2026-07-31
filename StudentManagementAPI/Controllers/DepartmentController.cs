using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using System.Linq;

namespace WebApplication1.Controllers;
[ApiController]
[Route("")]
public class DepartmentController : ControllerBase
{
    
    //to access the database
    private UniversityContext context;
    public DepartmentController(UniversityContext _context)
    {
        context = _context;
    }
    
    
    // Add
    [HttpPost]
    public IActionResult AddDepartment(Department d)
    {
        context.Departments.Add(d);
        context.SaveChanges();
        return Ok(d);
    }

    // Delete
    [HttpDelete("{id}")]
    public IActionResult RemoveDepartment(int id)
    {
        Department d = context.Departments.FirstOrDefault(d => d.DepartmentId == id);

        if (d == null)
        {
            return NotFound("Department not found.");
        }

        context.Departments.Remove(d);
        context.SaveChanges();
        return Ok("Department deleted successfully.");
    }

    // Get by ID
    [HttpGet("{id}")]
    public Department GetDepartment(int id)
    {
        Department d = context.Departments.FirstOrDefault(d => d.DepartmentId == id);
        return d;
    }

    // Get all
    [HttpGet]
    public List<Department> GetAllDepartments()
    {
        List<Department> departments = context.Departments.ToList();
        return departments;
    }

    // Update
    [HttpPut("{id}")]
    public IActionResult UpdateDepartment(int id, Department updatedDepartment)
    {
        Department d = context.Departments.FirstOrDefault(d => d.DepartmentId == id);

        if (d == null)
        {
            return NotFound("Department not found.");
        }

        d.DepartmentName = updatedDepartment.DepartmentName;
        d.Location = updatedDepartment.Location;

        context.SaveChanges();

        return Ok(d);
    }
    
    
    
}