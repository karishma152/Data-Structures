namespace DSAPractice.LeetCode.TwoPointers
{
    public class ContainerWithMostWater
    {
        //check if lenght of height is 0, if yes return -1
        //initialise two variable left=0 and right = heigt.Length -1
        //calculate are between those two
        //if right is greate than left, increase left, else increase right
        //calculate the area then and find out the max area
        public int MaxArea()
        {
            int[] height = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            if (height.Length == 0)
                return 0;
            int left = 0, right = height.Length - 1, maxArea = 0;
            while (left < right && right < height.Length)
            {
                int length = right - left;
                int minWall = Math.Min(height[left], height[right]);
                int area = length * minWall;
                maxArea = Math.Max(area, maxArea);
                if (height[right] > height[left])
                    left++;
                else
                    right--;

            }
            return maxArea;

        }
    }
}
