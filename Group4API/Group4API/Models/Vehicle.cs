// Made by Haseeb
using System.ComponentModel.DataAnnotations;

namespace Group4API.Models
{
    public class Vehicle
    {
        [Key]
        public int VehicleId { get; set; }
        [Required(ErrorMessage = "Vehicle name is required.")]
        public string? Make { get; set; } = string.Empty;
        [Required(ErrorMessage = "Vehicle model is required.")]
        public string? Model { get; set; } = string.Empty;
        [Range(1886, 2100, 
            ErrorMessage = "Provide a valid car manufacturing year.")]
        public int Year { get; set; }
        [Required(ErrorMessage = "Vehicle description is required.")]
        public string? Description { get; set; } = string.Empty;
        [Required(ErrorMessage = "Type of vehicle must be given.")]
        public string? VehicleType { get; set; } = string.Empty;
        [Required(ErrorMessage = "Size is a required attribute to provide.")]
        public string? Size { get; set; } = string.Empty;
        [Required(ErrorMessage = "Storage location value is required.")]
        public string? StorageLocation { get; set; } = string.Empty;
        [Required(ErrorMessage = "License plate is required.")]
        public string? LicensePlate { get; set; } = string.Empty;
        [Range(0, double.MaxValue,
            ErrorMessage = "Cannot provide a negative value for mileage.")]
        public double Mileage { get; set; }
        [Required(ErrorMessage = "Condition is a required value to provide.")]
        public string? Condition { get; set; } = string.Empty;
        public bool IsAvailable { get; set; }
    }
}
