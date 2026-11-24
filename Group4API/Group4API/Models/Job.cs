using System.ComponentModel.DataAnnotations;

namespace Group4API.Models;

// Made by Matthew
public class Job
{
    [Key]
    public int JobId { get; set; }
    public int ClientId { get; set; }
    public List<int> MaterialIds { get; set; } = new List<int>();
    public List<int> ToolIds { get; set; } = new List<int>();
    public List<int> VehicleIds { get; set; } = new List<int>();
    public string? JobType { get; set; }
}
