namespace Group4API.Models
{
    // MADE BY JOHNY
    public class Schedule
    {
        public int ScheduleId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int JobId { get; set; }
        //public List<Employee> EmployeeIds { get; set; }
    }
}
