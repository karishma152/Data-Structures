namespace DSAPractice.SystemDesign.BookMyShow.Modals
{
    public class Theatre
    {
        public int ThatreId { get; set; }
        public string ThatreName { get; set; }
        public string Location { get; set; }
        public List<Screen> screens { get; set; }
    }
}
