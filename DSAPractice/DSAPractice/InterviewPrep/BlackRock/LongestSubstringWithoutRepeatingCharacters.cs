using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice.InterviewPrep.BlackRock
{
    public class LongestSubstringWithoutRepeatingCharacters
    {
        //Brute force would be generating all substrings and checking if each substring has unique characters using a set.
        //This would be inefficient — around O(n³)
        public void LongestSubstringWithoutRepeatingCharacters_BruteForce(string s)
        {
            int maxLength = 0;
            string result = "";

            for (int i = 0; i < s.Length; i++)
            {
                var set = new HashSet<char>(); // using set for uniqueness check

                for (int j = i; j < s.Length; j++)
                {
                    // if duplicate → break early
                    if (set.Contains(s[j]))
                        break;

                    set.Add(s[j]); // store char

                    // calculate window size
                    maxLength = Math.Max(maxLength, j - i + 1);

                    // substring from i to j
                    string current = s.Substring(i, j - i + 1);

                    // update result if longer substring found
                    if (current.Length > result.Length)
                    {
                        result = current;
                    }
                }
            }

            Console.WriteLine("longest length is : " + maxLength);
            Console.WriteLine("longest substring is : " + result);
        }

        //To optimize, I can use a sliding window approach.
        //I’ll maintain a window using two pointers and a HashSet to track characters.
        //If I encounter a duplicate, I’ll shrink the window until it becomes valid again.
        //I’ll also store the start index of the best window.
        //At the end, I can return the substring using that index.
        public void LongestSubstringWithoutRepeatingCharacters_Optimized(string s)
        {
            int left = 0, maxLength = 0, startIndex = 0;
            var set = new HashSet<char>(); //track unique characters

            for (int right = 0; right < s.Length; right++)
            {
                //shrink the window if the duplicate is found
                while (set.Contains(s[right]))
                {
                    set.Remove(s[left]); // remove left char
                    left++;              // move window forward
                }

                set.Add(s[right]);
                int windowLength = right - left + 1;

                //check for longest
                if(windowLength > maxLength)
                {
                    maxLength = windowLength;
                    startIndex = left;
                }
            }

            Console.WriteLine("Longest substring length without repeating chars : " + maxLength);
            Console.WriteLine("Longest substring without repeating chars : " + s.Substring(startIndex, maxLength));
        }
    }
}
