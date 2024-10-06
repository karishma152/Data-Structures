namespace DSAPractice.LeetCode.TwoPointers
{
    public class MoveZeroes
    {
        //Initialise two pointers i = 0 and j = 1;
        //Check if i == 0, if yes then check if j !=0
        //if j!=0, then swap i and j, else increment j++ and i++,
        //if j==0, increment j++
        public void MoveZeroesQue()
        {
            int[] nums = { 0, 1, 0, 3, 12 };
            int i = 0, j = 1;
            while (i < nums.Length && j < nums.Length)
            {
                if (nums[i] == 0 && nums[j] != 0)
                {
                    int temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                    i++;
                    j++;
                }
                else if (nums[i] == 0 && nums[j] == 0)
                {
                    j++;
                }
                else if (nums[i] != 0)
                {
                    i++;
                }
                if (i >= j)
                {
                    j = i + 1;
                }
            }
        }
    }
}
