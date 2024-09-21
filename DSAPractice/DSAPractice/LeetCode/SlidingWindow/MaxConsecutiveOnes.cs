using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.LeetCode.SlidingWindow
{
    public class MaxConsecutiveOnes
    {
        public int LongestOnes(int[] nums, int k)
        {
            int minCount = 0, maxCount = 0, j = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                    minCount++;
                while (minCount > k && j <= i)
                {
                    if (nums[j] == 0)
                        minCount--;
                    j++;
                }
                maxCount = Math.Max(maxCount, i - j + 1);
            }
            return maxCount;
        }
    }
}
