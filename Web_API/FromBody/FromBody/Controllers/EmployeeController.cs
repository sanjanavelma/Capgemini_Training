using Microsoft.AspNetCore.Mvc;
using FromBody;

[ApiController]
[Route("api/[controller]")]
public class EmployeeController : ControllerBase
{
    // List to store employees
    private static List<Employee> employees = new List<Employee>();

    // Add multiple employees
    [HttpPost("add")]
    public IActionResult AddEmployees([FromBody] List<Employee> empList)
    {
        employees.AddRange(empList);

        return Ok("Employees added successfully");
    }

    // Get all employees
    [HttpGet("all")]
    public IActionResult GetAllEmployees()
    {
        return Ok(employees);
    }

    // Get total salary
    [HttpGet("totalsalary")]
    public IActionResult GetTotalSalary()
    {
        double total = employees.Sum(e => e.Salary);

        return Ok($"Total Salary = {total}");
    }
}