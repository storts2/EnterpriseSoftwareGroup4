using System.ComponentModel.DataAnnotations;

namespace Group4API.Models;

// Made by Matthew
public class ScheduleEntry
{
    [Key]
    public int ScheduleEntryId { get; set; }
    public int JobId { get; set; }
    public List<int> EmployeeIds { get; set; } = new List<int>();
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
}
