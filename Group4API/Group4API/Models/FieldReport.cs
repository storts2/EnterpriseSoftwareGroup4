// Made by Nabeel

using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace Group4API.Models
{
    public class FieldReport
    {
        [Key]
        public int ReportID { get; set; }

        public DateOnly Date { get; set; }

        public bool Arrived { get; set; }

        public bool QuotaComplete { get; set; }

        public Employee EmployeeID { get; set; }
    }
}
