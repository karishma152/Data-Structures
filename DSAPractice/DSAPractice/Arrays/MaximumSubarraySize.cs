namespace DSAPractice.Arrays
{
    public class MaximumSubarraySize
    {
        /// <summary>
        /// Given an array of n positive integers and a positive integer k, 
        /// the task is to find the maximum subarray size such that 
        /// all subarrays of that size have the sum of elements less than or equals to k.
        /// </summary>
        public void MaximumSubarraySizeQue()
        {
            int[] arr = { 1, 2, 3, 4 };
            int maxSum = 8, tempSum = 0, j = 0, n = 0,temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i > maxSum)
                    Console.WriteLine("Maximum Subarray Size: ", -1);
                else if(i == maxSum)
                    Console.WriteLine("Maximum Subarray Size: ", 1);
                else
                {
                    n = 2;
                }
            }

            while (n < arr.Length)
            {
                for (int i = n; i < arr.Length; i++)
                {
                    for(int k = 0; k <n; k++)
                    {
                        temp += arr[k];
                    }
                    tempSum = temp + arr[i] - arr[i - n];
                    if (tempSum >= maxSum)
                    {
                        n = n + 1;
                        temp = 0;
                    }
                    else
                    {
                        temp = tempSum;
                        
                    }
                }
            }
        }
    }
}
