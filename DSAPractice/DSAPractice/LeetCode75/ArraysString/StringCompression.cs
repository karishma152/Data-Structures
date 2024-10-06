using System;
using System.Linq;
using System.Text;

namespace DSAPractice.LeetCode.ArraysString
{
    public class StringCompression
    {
        /// <summary>
        /// Given an array of characters chars, compress it using the following algorithm:
        ///Begin with an empty string s.For each group of consecutive repeating characters in chars:
        ///If the group's length is 1, append the character to s.
        ///Otherwise, append the character followed by the group's length.
        ///The compressed string s should not be returned separately, but instead, 
        ///be stored in the input character array chars.
        ///Note that group lengths that are 10 or longer will be split into multiple characters in chars.
        ///After you are done modifying the input array, return the new length of the array.
        ///You must write an algorithm that uses only constant extra space.
        /// </summary>
        public void StringCompressionQue()
        {
            char[] chars = { 'a', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b' };
            int writeIndex = 0;
            int i = 0;
            while (i < chars.Length)
            {
                int count = 0;
                char c = chars[i];
                while (i < chars.Length && chars[i] == c)
                {
                    i++;
                    count++;
                }
                chars[writeIndex++] = c;
                if (count > 1)
                {
                    foreach (char digit in count.ToString())
                    {
                        chars[writeIndex++] = digit;
                    }
                }
            }
            Console.WriteLine(writeIndex);
        }
    }
}
