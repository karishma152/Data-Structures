namespace DSAPractice.LeetCode.ArraysString
{
    public class MergeStringsAlternatively
    {
        #region Public Methods

        public string MergeAlternately()
        {
            string word1 = Console.ReadLine();
            string word2 = Console.ReadLine();
            int word1Len = word1.Length;
            int word2Len = word2.Length;
            string result = string.Empty;
            int length = Math.Min(word1.Length, word2.Length);
            for(int i = 0; i < length; i++)
            {
                result += word1[i];
                result += word2[i];
            }
            if(word1Len > word2Len)
            {
                for (int i = word2Len; i < word1.Length; i++)
                {
                    result += word1[i];
                }
            }
            else
            {
                for (int i = word1Len; i < word2.Length; i++)
                {
                    result += word2[i];
                }
            }
            
            Console.WriteLine(result);
            return result;
        }

        #endregion
    }
}
