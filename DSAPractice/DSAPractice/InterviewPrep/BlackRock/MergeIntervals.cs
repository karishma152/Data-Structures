namespace DSAPractice.InterviewPrep.BlackRock
{
    //Given an array of intervals, merge all overlapping intervals.
    public class MergeIntervals
    {
        //I’ll start with a brute-force approach where I compare every interval with others, but that would be O(n²)
        public int[][] MergeIntervals_Optimized(int[][] intervals)
        {
            if (intervals.Length == 0)
                return new int[0][];

            //Step 1: Sorting the intervals
            Array.Sort(intervals, (a,b) => a[0].CompareTo(b[0]));
            List<int[]> result = new List<int[]>();

            //Step 2: Add the first interval
            result.Add(intervals[0]);

            for (int i = 1; i < intervals.Length; i++)
            {
                int[] last = result[result.Count - 1];
                int[] cur = intervals[i];

                //overlapping condition
                if(cur[0] <= last[1])
                    last[1] = Math.Max(last[1], cur[1]);
                else
                    result.Add(cur);
            }
            foreach (int[] last in result)
            {
                Console.WriteLine("[" + last[0] + ","+ last[1] + "]");

            }
            return result.ToArray();

        }
    }
}
