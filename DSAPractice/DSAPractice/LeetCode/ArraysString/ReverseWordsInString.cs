using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.LeetCode.ArraysString
{
    public class ReverseWordsInString
    {
        public void ReverseWordsInStringQue()
        {
            string s = "the sky is blue";
            string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
            Array.Reverse(words);
            s = string.Join(" ", words);

            Console.Write(s);

        }
    }
}
