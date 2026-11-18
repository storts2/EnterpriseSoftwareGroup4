// Made by Nabeel

namespace Group4API.Models
{
    public class Warehouse
    {
        public int ShelfID { get; set; }

        public List<int> EmptyShelves { get; set; }

        public List<int> FilledShelves { get; set; }

        public string EmployeeJobs { get; set; }
    }
}
