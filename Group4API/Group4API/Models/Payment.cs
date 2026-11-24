using System.ComponentModel.DataAnnotations;

namespace Group4API.Models
{
    // MADE BY JOHNY
    public class Payment
    {
        [Key]
        public int PaymentID { get; set; }

        [Required (ErrorMessage = "Payment direction is required")]
        public string PaymentDirection { get; set; }

        [Required (ErrorMessage = "Payment amount is required")]
        public decimal PaymentAmount { get; set; }

        [Required (ErrorMessage = "Payment date is required")]
        public DateTime PaymentDate { get; set; }

        [Required (ErrorMessage = "Payment category is required")]
        public string PaymentCategory { get; set; }
    }
}
