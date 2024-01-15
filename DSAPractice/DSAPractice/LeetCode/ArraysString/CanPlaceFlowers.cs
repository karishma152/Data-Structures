namespace DSAPractice.LeetCode.ArraysString
{
    public class CanPlaceFlowers
    {
        #region Public Methods

        public void CanPlaceFlowersOutput()
        {
            int[] flowerBed = { 1, 0, 0, 0, 0, 1 };
            int n = 2;
            for (int i = 0; i < flowerBed.Length; i++)
            {
                if (flowerBed[i] == 0
                    && flowerBed.ElementAtOrDefault(i - 1) == 0
                    && flowerBed.ElementAtOrDefault(i + 1) == 0)
                {
                    flowerBed[i] = 1;
                    n--;
                }
            }
            if (n <= 0)
                Console.WriteLine(true);
            else
                Console.WriteLine(false);

        }

        #endregion
    }
}
