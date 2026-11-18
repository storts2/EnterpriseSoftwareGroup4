// Made by Nabeel

using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Group4API.Models
{
    public class FieldReport
    {
        public int ReportID { get; set; }

        public DateOnly Date { get; set; }

        public bool Arrived { get; set; }

        public bool QuotaComplete { get; set; }

        public Employee employeeID { get; set; }

        public Employee employee { get; set; }
    }
}
