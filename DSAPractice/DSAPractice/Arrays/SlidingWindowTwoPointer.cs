using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.Arrays
{
    public class SlidingWindowTwoPointer
    {
        public void SlidingWindowTwoPointerQue()
        {
            int[] arr = { 1, 0, 3, 5, 10 };
            int maxSum = 10, tempSum = 0, j = 0,minLength = Int32.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                tempSum = tempSum + arr[i];
                while (tempSum >= maxSum && j <= i)
                {
                    // If the current sum equals maxSum, update minLength
                    if (tempSum == maxSum)
                    {
                        minLength = Math.Min(minLength, i - j + 1);
                    }

                    // Shrink the window from the left
                    tempSum -= arr[j];
                    j++;
                }


            }
            Console.WriteLine("Width of subarray with " + maxSum + " is: " + minLength);
        }
    }
}
