using DSAPractice.SystemDesign.BookMyShow.Interface;

namespace DSAPractice.SystemDesign.BookMyShow.Service
{
    public class PaymentService
    {
        public bool ProcessPayment(decimal amount, IPaymentStrategy strategy)
        {
            return strategy.Pay(amount);
        }
    }
}
