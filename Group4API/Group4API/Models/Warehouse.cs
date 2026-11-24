// Made by Nabeel

using System.ComponentModel.DataAnnotations;

namespace Group4API.Models
{
    public class Warehouse
    {
        [Key]
        public int ShelfID { get; set; }

        public List<int> EmptyShelves { get; set; }

        public List<int> FilledShelves { get; set; }

        public string EmployeeJobs { get; set; }
    }
}
