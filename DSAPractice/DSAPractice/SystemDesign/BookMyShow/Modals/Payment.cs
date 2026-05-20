using DSAPractice.SystemDesign.BookMyShow.Enums;

namespace DSAPractice.SystemDesign.BookMyShow.Modals
{
    public class Payment
    {
        public int PaymentId { get; set; }

        public decimal Amount { get; set; }

        public PaymentStatusEnum Status { get; set; }

        public IPaymentStrategy Strategy { get; set; }
    }
}
