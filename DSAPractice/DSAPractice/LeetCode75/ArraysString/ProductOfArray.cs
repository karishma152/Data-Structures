using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.LeetCode.ArraysString
{
    public class ProductOfArray
    {
        /// <summary>
        /// Brute Force Approach
        /// </summary>
        public void ProductOfArrayQue()
        {
            int[] nums = { 1, 2, 3, 4 };
            int[] ans = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                int prod = 1;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i == j)// In case both the indexes are same we omit them
                        continue;
                    prod = prod * nums[j];
                }
                ans[i] = prod;
                Console.WriteLine("Product of Array " + ans[i]);
            }

        }

        /// <summary>
        /// Division Approach
        /// </summary>
        public void ProductOfArrayQueEfficient()
        {
            int[] nums = { -1, 1, 0, -3, 3 };
            int productOfArray = 1;
            int productOfZeroArray = 1;
            int zeroElementCount = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    productOfZeroArray = productOfZeroArray * nums[i]; // calculating the product of every element of array for element that is 0;
                }
                else
                {
                    zeroElementCount++;
                }

                productOfArray = productOfArray * nums[i];// product of array for all

            }
            if (zeroElementCount > 1)
            {
                productOfArray = 0; // if there is more than one zero element then product is 0;
                productOfZeroArray = 0; // if there are more than one zero element, product of zero is also zero
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[i] = productOfArray / nums[i]; //dividing the number by the element at index i to get it's product
                }
                else
                {
                    nums[i] = productOfZeroArray;
                }

                Console.WriteLine("Product of Array " + nums[i]);
            }
        }

        /// <summary>
        /// Prefix Product Calculation
        /// Suffix Product Calculation
        /// Product of prefix and sufix is product of arrat except self
        /// </summary>
        public void PreFixSufixApproach()
        {
            int[] nums = { 1, -1, 0, 3, 9 };
            int[] prefix = new int[nums.Length]; // prefix array where product for prefix would be stored
            int[] suffix = new int[nums.Length];// ans array where product for suffix would be stored
            prefix[0] = 1;
            suffix[nums.Length - 1] = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                prefix[i] = prefix[i - 1] * nums[i - 1]; // since the prefix of just the element
                                                         // before would be product of the previous elements
            }
            for (int i = nums.Length - 2; i >= 0; i--)
            {
                suffix[i] = suffix[i + 1] * nums[i + 1]; // since the prefix * suffix of element =  product

            }

            for(int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine("product except self for " + nums[i] + " : " + suffix[i] * prefix[i]);
            }



        }
    }
}

