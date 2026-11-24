using System.ComponentModel.DataAnnotations;

namespace Group4API.Models
{
    // MADE BY JOHNY
    public class Schedule
    {
        [Key]
        public int ScheduleId { get; set; }

        [Required (ErrorMessage = "Start date is required")]
        public DateTime StartDate { get; set; }

        [Required (ErrorMessage = "End date is required")]
        public DateTime EndDate { get; set; }

        [Required (ErrorMessage = "Job ID is required")]
        public int JobId { get; set; }
        //public List<Employee> EmployeeIds { get; set; }
    }
}
