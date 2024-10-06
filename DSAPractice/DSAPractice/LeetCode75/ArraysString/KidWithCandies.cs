namespace DSAPractice.LeetCode.ArraysString
{
    public class KidWithCandies
    {
        #region Public Methods

        public void KidsWithCandies()
        {
            int[] candies = { 2,8,7};
            int extraCandies = 1;
            bool[] result = new bool[candies.Length];
            int index = candies.Max();
            for (int i = 0; i < candies.Length; i++)
            {
                result[i] = true ? candies[i] + extraCandies >= index : false;
            }
            for (int i = 0; i < candies.Length; i++)
                Console.WriteLine(result[i]);
        }

        #endregion
    }
}
