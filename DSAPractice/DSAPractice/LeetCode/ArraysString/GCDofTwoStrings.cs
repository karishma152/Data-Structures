﻿namespace DSAPractice.LeetCode.ArraysString
{
    public class GCDofTwoStrings
    {
        #region Public Methods

        public void GCDofTwoStringsOptimised()
        {
            string string1 = Console.ReadLine();
            string string2 = Console.ReadLine();
            string baseString = string.Empty;
            if (string1.Length > string2.Length)
                baseString = string2;
            else
                baseString = string1;
            if (string1 + string2 == string2 + string1)
            {
                int gcd = FindGCDofTwoNumber(string1.Length, string2.Length);
                string result = string1.Substring(0, gcd);
                Console.WriteLine(String.Format("GCD of two strings by Optimised Solution is : " + result));
            }
            else
                Console.WriteLine("Strings don't have GCD");
        }

        #endregion

        #region Private Methods

        private int FindGCDofTwoNumber(int num1, int num2)
        {
            int min = Math.Min(num1, num2);
            int result = 0;
            for (int i = min; i > 0; i--)
            {
                if (num1 % i == 0 && num2 % i == 0)
                {
                    result = i;
                    break;
                }

            }
            return result;
        }

        #endregion
    }
}
