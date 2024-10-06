using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.LeetCode.HashMaps_Sets
{
    public class FindDifferenceOfTwoArrays
    {
        public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
            IList<int> distinctNum1 = new List<int>();
            IList<int> distinctNum2 = new List<int>();
            foreach (int i in nums1)
            {
                if (Array.IndexOf(nums2, i) == -1 && !distinctNum1.Contains(i))
                    distinctNum1.Add(i);
            }
            foreach (int i in nums2)
            {
                if (Array.IndexOf(nums1, i) == -1 && !distinctNum2.Contains(i))
                    distinctNum2.Add(i);
            }
            IList<IList<int>> result = new List<IList<int>>();
            result.Add(distinctNum1);
            result.Add(distinctNum2);
            return result;
        }
    }
}
