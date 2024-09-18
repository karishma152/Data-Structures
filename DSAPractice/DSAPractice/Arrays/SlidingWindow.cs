using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.Arrays
{
    public class SlidingWindow
    {
        public void SlidingWindowQue()
        {
            int[] arr = { 1, 0, 3, 5, 2 };
            int n = 3, maxSum = 0;
            for (int i = 0; i < n; i++)
            {
                maxSum += arr[i];
            }
            int tempSum = maxSum;
            for (int i = n; i < arr.Length; i++)
            {
                tempSum = tempSum + arr[i] - arr[i - n];
                maxSum = Math.Max(maxSum, tempSum);
            }
            Console.WriteLine("Maximum sum of " + n + " length of subarray is: " + maxSum);
        }
    }
}
