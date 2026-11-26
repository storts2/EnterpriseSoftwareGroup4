using Group4API.Models;
// MADE BY JOHNY
namespace Group4API.Repositories
{
    public interface IPaymentRepository
    {
        public IEnumerable<Payment> GetAllPayments();
        public Payment GetPaymentById(int id);
        public Payment AddPayment(Payment payment);
        public void DeletePaymentById(int id);
        public void UpdatePayment(Payment payment);

    }
}
