using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.LeetCode.HashMaps_Sets
{
    public class UniqueNumberOfOccurrences
    {
        public bool UniqueOccurrences(int[] arr)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();
            foreach (int i in arr)
            {

                if (!result.ContainsKey(i))
                {
                    result.Add(i, 1);
                }
                else
                {
                    result[i] = result[i] + 1; ;
                }
            }
            if (result.Values.Distinct().Count() == result.Values.Count())
                return true;
            else
                return false;

        }
    }
}
