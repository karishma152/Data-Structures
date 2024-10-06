namespace DSAPractice.LeetCode.SlidingWindow
{
    public class MaximumAverageSubarray1
    {
        public double MaxAvgSubArray(int[] nums, int k)
        {
            double maxAvgVal = 0, tempVal = 0;
            for (int i = 0; i < k; i++)
            {
                maxAvgVal += nums[i];
            }
            maxAvgVal = maxAvgVal;
            tempVal = maxAvgVal;
            for (int i = k; i < nums.Length; i++)
            {
                tempVal = tempVal + nums[i] - nums[i - k];
                maxAvgVal = Math.Max(tempVal, maxAvgVal);
            }
            return maxAvgVal / k;
        }
    }
}
