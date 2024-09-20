namespace DSAPractice.LeetCode.ArraysString
{
    public class ReverseVowels
    {
        #region Public Methods

        public void ReverseVowelsInString()
        {
            string s = "IceCream";
            var chars = s.ToList();
            List<char> template = new List<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            List<char> vowels = new();
            int numberOfVowels = 0;
            foreach (char c in s)
            {
                if (template.Contains(c))
                {
                    vowels.Add(c);
                    numberOfVowels++;

                }
            }
            for(int i=0;i<s.Length;i++)
            {
                if (template.Contains(s[i]))
                {
                    chars[i] = vowels[numberOfVowels - 1];
                    numberOfVowels--;
                }
            }
            s = chars.ToString();
           foreach(char ch in chars)
            {
                Console.Write(ch);
            }

        }

        #endregion
    }
}
