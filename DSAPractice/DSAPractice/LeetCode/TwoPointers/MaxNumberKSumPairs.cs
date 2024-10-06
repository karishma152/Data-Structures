namespace DSAPractice.LeetCode.TwoPointers
{
    public class MaxNumberKSumPairs
    {
        //sort the array and check if array.Length>0, if not return 0
        //initalize three integers left = 0, right = nums.Length -1 ans ans = 0
        //check if left + right == k if yes then increment left and decrease right, and increment ans
        //else if left + right > k, right -- 
        //else if left + right < k, left ++;
        public int MaxOperations()
        {
            int[] nums = { 1, 2, 3, 4 };
            int k = 5;
            int left = 0, right = nums.Length - 1, ans = 0;
            if (nums.Length == 0)
                return ans;
            Array.Sort(nums);
            while (left < right)
            {
                if (nums[left] + nums[right] == k)
                {
                    left++;
                    right--;
                    ans++;
                }
                else if (nums[left] + nums[right] > k)
                    right--;
                else if (nums[left] + nums[right] < k)
                    left++;
            }
            return ans;
        }
    }
}
