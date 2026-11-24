using System.ComponentModel.DataAnnotations;

namespace Group4API.Models;

// Made by Matthew
public class Job
{
    [Key]
    public int JobId { get; set; }
    public int ClientId { get; set; }
    public List<Material> Material { get; set; } = new List<Material>();
    public List<Tools> Tool { get; set; } = new List<Tools>();
    public List<Vehicle> Vehicle { get; set; } = new List<Vehicle>();
    public string? JobType { get; set; }
}
