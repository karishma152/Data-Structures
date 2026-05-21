namespace DSAPractice.SystemDesign.SplitWise.Modals
{
    public class Expense
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public decimal TotalAmount { get; set; }
        public User PaidBy { get; set; }
        public Group Group { get; set; }
        public List<ExpenseSplit> Splits { get; set; } 
    }
}
