using DSAPractice.SystemDesign.BookMyShow.Interface;

namespace DSAPractice.SystemDesign.BookMyShow.Service
{
    public class UpiPaymentService : IPaymentStrategy
    {
        public bool Pay(decimal amount)
        {
            return true;
        }
    }
}
