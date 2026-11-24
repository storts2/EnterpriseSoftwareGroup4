using Group4API.Models;
using Group4API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Group4API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EmployeeController : ControllerBase
{
    private readonly IEmployeeRepo _employees;

    public EmployeeController (IEmployeeRepo employees)
    {
        _employees = employees;
    }

    [HttpGet]
    public IEnumerable<Employee> GetAllEmployees()
    {
        return _employees.GetAllEmployees();
    }

    [HttpGet("{id}")]
    public ActionResult<Employee> GetEmployeeById(int id)
    {
        Employee employee = _employees.GetEmployeeById(id);
        if (employee != null)
        {
            return employee;
        }
        return NotFound();
    }

    [HttpPost]
    public ActionResult<Employee> Post([FromBody] Employee employee)
    {
        Employee addEmployee = _employees.AddEmployee(employee);

        return CreatedAtAction("GetEmployeeById", new { id = addEmployee.EmployeeId }, addEmployee);
    }

    [HttpDelete("{id}")]
    public ActionResult DeleteEmployeeById(int id) 
    {
        Employee employee = _employees.GetEmployeeById(id);

        if (employee == null)
        {
            return NotFound();
        }

        _employees.DeleteEmployeeById(id);

        return NoContent();
    }
}
