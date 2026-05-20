namespace DSAPractice.SystemDesign.BookMyShow.Interface
{
    public interface IPaymentStrategy
    {
        bool Pay(decimal amount);
    }
}
