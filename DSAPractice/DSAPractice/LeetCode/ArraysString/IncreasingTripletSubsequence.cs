using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.LeetCode.ArraysString
{
    public class IncreasingTripletSubsequence
    {
        public void IncreasingTripletSubsequenceQue()
        {
            int[] nums = { 4,3,2,1 };
            int smallest = Int32.MaxValue;
            int secondSmallest = Int32.MaxValue;
            foreach (int num in nums)
            {
                if (num <= smallest)
                {
                    smallest = num; // it will check if the num is smaller than smallest
                }
                else if (num <= secondSmallest)
                {
                    secondSmallest = num; // if number is not smaller than smallest but is smaller than second smallest
                }
                else
                {
                    Console.WriteLine(true); // if a number is bigger than smallest and second smallest, then we have a triplet
                }
            }

        }
    }
}
