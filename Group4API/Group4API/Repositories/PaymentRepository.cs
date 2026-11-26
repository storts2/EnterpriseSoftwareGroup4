using Group4API.DataAccessLayer;
using Group4API.Models;

namespace Group4API.Repositories
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly JobManagementDbContext _context;
        public PaymentRepository(JobManagementDbContext context)
        {
            _context = context;
        }

        public Payment AddPayment(Payment payment)
        {
            if (payment == null)
            {
                throw new ArgumentNullException("Payment information is invalid.\n");
            }
            _context.Payments.Add(payment);
            _context.SaveChanges();
            return payment;
        }

        public void DeletePaymentById(int id)
        {
            var payment = GetPaymentById(id);
            if (payment != null)
            {
                _context.Payments.Remove(payment);
                _context.SaveChanges();
            }
            else
            {
                throw new ArgumentNullException("Payment id is not found.\n");
            }
        }

        public IEnumerable<Payment> GetAllPayments()
        {
            return _context.Payments;
        }

        public Payment GetPaymentById(int id)
        {
            return _context.Payments.FirstOrDefault(p => p.PaymentID == id);
        }

        public void UpdatePayment(Payment payment)
        {
            var existingPayment = GetPaymentById(payment.PaymentID);
            if (existingPayment != null)
            {
                existingPayment.PaymentAmount = payment.PaymentAmount;
                existingPayment.PaymentDate = payment.PaymentDate;
                existingPayment.PaymentDirection = payment.PaymentDirection;
                existingPayment.PaymentCategory = payment.PaymentCategory;
                _context.SaveChanges();
            }
            else
            {
                throw new ArgumentNullException("Payment id is not found.\n");
            }
        }
    }
}
