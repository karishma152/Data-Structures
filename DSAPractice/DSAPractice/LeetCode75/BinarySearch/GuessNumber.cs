using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.LeetCode.BinarySearch
{
    public class GuessNumber
    {
        public int GuessNumberQue()
        {
            int n = 10;
            int mid = n / 2;
            int gues = guess(mid);
            if (gues == 1)
            {
                for (int i = mid + 1; i <= n; i++)
                {
                    if (guess(i) == 0)
                    {
                        return i;
                    }
                }
            }
            else if (gues == -1)
            {
                for (int i = 1; i < mid; i++)
                {
                    if (guess(i) == 0)
                    {
                        return i;
                    }
                }
            }
            else
            {
                return mid;
            }
            return mid + 1;
        }
        public int guess(int n)
        {
            int k = 5;
            if (k == n)
                return 0;
            else if (k < n)
                return 1;
            else
                return -1;
        }
    }
}
