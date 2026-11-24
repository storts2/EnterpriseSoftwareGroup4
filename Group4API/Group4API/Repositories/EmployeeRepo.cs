using Group4API.DataAccessLayer;
using Group4API.Models;

namespace Group4API.Repositories;

// Made by Matthew
public class EmployeeRepo : IEmployeeRepo
{
    private readonly JobManagementDbContext _context;

    public EmployeeRepo(JobManagementDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Employee> GetAllEmployees()
    {
        return _context.Employees;
    }

    public Employee GetEmployeeById(int id)
    {
        return _context.Employees.FirstOrDefault(e => e.EmployeeId == id);
    }

    public Employee AddEmployee(Employee employee)
    {
        _context.Employees.Add(employee);
        _context.SaveChanges();

        return employee;
    }

    public void DeleteEmployeeById(int id)
    {
        Employee deletedEmployee = GetEmployeeById(id);

        if (deletedEmployee != null) 
        { 
            _context.Employees.Remove(deletedEmployee);
            _context.SaveChanges();
        }
    }
}
