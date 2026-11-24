// Made by Nabeel

using System.ComponentModel.DataAnnotations;

namespace Group4API.Models
{
    public class Material
    {
        [Key]
        public int MaterialID { get; set; }

        public string Name { get; set; }

        public string Category { get; set; }

        public int Quantity { get; set; }

        public List<int> StorageLocation { get; set; }

        public double Price { get; set; }
    }
}
