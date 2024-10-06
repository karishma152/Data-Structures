namespace DSAPractice.LeetCode.TwoPointers
{
    public class IsSubsequence
    {
        //check if s.Length > t.Length, if yes then continue else return false
        //initialise a int count as flag, i(will iterate through s) and j(will iterate through t)
        //run a while loop untill i<s.Length and j < t.Length
        //if s[i] == t[j] => i++,j++, count++,
        //if s[i] != t[j] => j++,
        //after the while loop check if count== s.length
        public bool IsSubsequenceQue()
        {
            string s = "abc", t = "abchabc";
            if (s.Length > t.Length)
                return false;
            int count = 0, i = 0, j = 0;
            while (i < s.Length && j < t.Length)
            {
                if (s[i] == t[j])
                {
                    i++;
                    j++;
                    count++;
                }
                else if (s[i] != t[j])
                {
                    j++;
                }
            }
            if (count != s.Length)
            {
                return false;
            }
            return true;
        }
    }
}
