namespace DSAPractice.SystemDesign.SplitWise.Modals
{
    public class BalanceSheet
    {
        public Guid BalanceId { get; set; }
        public User Lender { get; set; }
        public User Borrower { get; set; }
        public decimal Amount { get; set; }
    }
}
