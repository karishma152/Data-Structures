using static System.Formats.Asn1.AsnWriter;

namespace DSAPractice.InterviewPrep.BlackRock
{
    public class SubArraySum
    {
        //Brute force would be checking all subarrays which takes O(n²).
        //To optimize, I’ll use prefix sum and a hashmap to store previously seen sums.
        public void SubArraySum_Optimized(int[] nums, int k)
        {
            var map = new Dictionary<int, int>(); // sum → frequency

            map[0] = 1; // edge case for sum=k from start

            int sum = 0;
            int count = 0;

            foreach (var num in nums)
            {
                sum += num;

                // check if required sum exists
                if (map.ContainsKey(sum - k))
                {
                    count += map[sum - k];
                }

                if (!map.ContainsKey(sum))
                    map[sum] = 0;

                map[sum]++;
            }

            Console.WriteLine("Count of sub array" + count);
        }
    }
}
