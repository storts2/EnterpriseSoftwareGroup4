using Group4API.Models;

namespace Group4API.Repositories;

// Made by Matthew
public interface IEmployeeRepo
{
    IEnumerable<Employee> GetAllEmployees();

    Employee GetEmployeeById(int id);

    Employee AddEmployee(Employee employee);

    void DeleteEmployeeById(int id);
}
