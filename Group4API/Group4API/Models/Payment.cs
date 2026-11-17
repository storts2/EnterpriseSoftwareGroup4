namespace Group4API.Models
{
    // MADE BY JOHNY
    public class Payment
    {
        public int PaymentID { get; set; }
        public string PaymentDirection { get; set; }
        public decimal PaymentAmount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentCategory { get; set; }
    }
}
