// Made by Haseeb
using System.ComponentModel.DataAnnotations;

namespace Group4API.Models
{
    public class Tools
    {
        [Key]
        public int ToolId { get; set; }
        [Required(ErrorMessage = "Tool name value is required.")]
        [StringLength(100)]
        public string? Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Description is required.")]
        public string? Description { get; set; } = string.Empty;
        [Required(ErrorMessage = "Category is required.")]
        public string? Category { get; set; } = string.Empty;
        [Required(ErrorMessage = "Brand is required.")]
        public string? Brand { get; set; } = string.Empty;
        [Range(0, int.MaxValue,
            ErrorMessage = "Cannot provide a negative value for quality.")]
        public int Quantity { get; set; }
        [Range(0, int.MaxValue,
            ErrorMessage = "Cannot provide a negative available quantity value.")]
        public int AvailableQuantity { get; set; }
        [Required(ErrorMessage = "Storage location is required.")]
        public string? StorageLocation { get; set; } = string.Empty;
        [Range(typeof(decimal), "0.01", "1000000.00",
            ErrorMessage = "Price cannot be a negative value.")]
        public decimal? UnitPrice { get; set; }
        [Required(ErrorMessage = "Condition value cannot be blank.")]
        public string? Condition { get; set; } = string.Empty;
        [Range(0, int.MaxValue,
            ErrorMessage = "The minimum stock requirement level cannot be negative.")]
        public int MinimumStockLevel { get; set; }
        public bool IsAvailable { get; set; }
    }
}
