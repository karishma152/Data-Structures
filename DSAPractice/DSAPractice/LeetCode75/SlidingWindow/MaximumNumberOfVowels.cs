namespace DSAPractice.LeetCode.SlidingWindow
{
    public class MaximumNumberOfVowels
    {
        public int MaxVowels(string s, int k)
        {
            int maxCount = 0, tempCount = 0;
            char[] nums = s.ToCharArray();
            char[] template = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            for (int i = 0; i < k; i++)
            {
                if (template.Contains(nums[i]))
                    maxCount++;
            }
            tempCount = maxCount;
            for (int i = k; i < nums.Length; i++)
            {
                if (template.Contains(nums[i - k]))
                    tempCount--;
                if (template.Contains(nums[i]))
                {
                    tempCount = tempCount + 1;
                }
                maxCount = Math.Max(tempCount, maxCount);
            }
            return maxCount;
        }
    }
}
