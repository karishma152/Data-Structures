namespace DSAPractice
{
    public class Patterns
    {
        #region Public Methods

        /// <summary>
        /// 1 4
        /// 2 3
        /// 3 2
        /// 4 1
        /// </summary>
        public void PrintingPattern1()
        {
            //value of n can vary and can be taken from user as well using Console.Readline
            int n = 5;

            //Optimal solution
            for (int i = 1; i < n; i++)
            {
                Console.WriteLine(i + " " + (n - i - 1));
            }

        }

        /// <summary>
        /// Rotating a matrix clockise by 90 degree
        /// Input:
        ///1 2 3 
        ///4 5 6
        ///7 8 9  
        /// </summary>
        public void PrintingPattern2()
        {
            int[,] arr = {{1, 2, 3, 4},
                  {5, 6, 7, 8},
                  {9, 10, 11, 12},
                  {13, 14, 15, 16}};

            //Basic Solution
            BasicSolution(arr, 4);
        }

        #endregion

        #region Private Methods

        private void MatrixTranspose(int[,] arr, int n)
        {

        }

        private void BasicSolution(int[,] arr, int n)
        {
            int[,] newArr = new int[n, n];
            for (int row = 0; row < n; row++)
            {
                for (int col = n - 1; col >= 0; col--)
                {
                    var temp = arr[row, col];
                    newArr[col, (n - row - 1)] = temp;
                }
            }
            print(newArr);
        }

        private void print(int[,] arr)
        {
            {
                int n = arr.GetLength(0);
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                        Console.Write(arr[i, j] + " ");

                    Console.WriteLine();
                }
            }
        }
        #endregion
    }
}
