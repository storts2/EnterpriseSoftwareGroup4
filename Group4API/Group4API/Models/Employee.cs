using System.ComponentModel.DataAnnotations;

namespace Group4API.Models;

// Made by Matthew
public class Employee
{
    [Key]
    public int EmployeeId { get; set; }
    public string? EmployeeName { get; set; }
    public string? Role { get; set; }
}
