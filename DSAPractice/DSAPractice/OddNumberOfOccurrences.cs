namespace DSAPractice
{
    public class OddNumberOfOccurrences
    {
        public static void OutputOnlyIntegersGreaterThanZero()
        {

            char[] input = { 'R', 'G', 'B', 'R', 'R', 'G', 'G', 'B' };
            char[] sortedOrder = { 'G', 'B', 'R' };
           
            char[] temp = input.OrderBy(x => Array.IndexOf(sortedOrder, x)).ToArray();
            Console.WriteLine(temp);
        }

        public static void Main(string[] args)
        {
            OddNumberOfOccurrences.OutputOnlyIntegersGreaterThanZero();
        }

    }
}
