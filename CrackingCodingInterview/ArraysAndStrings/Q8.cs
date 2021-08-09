namespace CrackingCodingInterview.ArraysAndStrings
{
    public class Q8
    {
        public void SetZeroesS1(int[,] matrix)
        {
            bool[] zeroRow = new bool[matrix.GetLength(0)];
            bool[] zeroCol = new bool[matrix.GetLength(1)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        zeroRow[i] = true;
                        zeroCol[j] = true;
                    }
                }
            }

            for (int row = 0; row < zeroRow.Length; row++)
                if (zeroRow[row])
                    for (int col = 0; col < matrix.GetLength(1); col++)
                        matrix[row, col] = 0;


            for (int col = 0; col < zeroCol.Length; col++)
                if (zeroCol[col])
                    for (int row = 0; row < matrix.GetLength(0); row++)
                        matrix[row, col] = 0;
        }

        public void SetZeroesS2(int[,] matrix)
        {
            bool firstRowHasZero = false;
            bool firstColHasZero = false;

            // check first row only
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (matrix[row, 0] == 0)
                {
                    firstColHasZero = true;
                    break;
                }
            }

            // check first column only
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (matrix[0, col] == 0)
                {
                    firstRowHasZero = true;
                    break;
                }
            }

            // check other row & col except first
            for (int row = 1; row < matrix.GetLength(0); row++)
            {
                for (int col = 1; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 0)
                    {
                        // row contains 0 -> mark first column of row 
                        matrix[row, 0] = 0;

                        // column contains 0 -> mark first row of column
                        matrix[0, col] = 0;
                    }
                }
            }

            for (int row = 1; row < matrix.GetLength(0); row++)
                if (matrix[row, 0] == 0)
                    for (int col = 1; col < matrix.GetLength(1); col++)
                        matrix[row, col] = 0;

            for (int col = 1; col < matrix.GetLength(1); col++)
                if (matrix[0, col] == 0)
                    for (int row = 1; row < matrix.GetLength(0); row++)
                        matrix[row, col] = 0;

            if (firstRowHasZero)
                for (int col = 0; col < matrix.GetLength(1); col++)
                    matrix[0, col] = 0;

            if (firstColHasZero)
                for (int row = 0; row < matrix.GetLength(0); row++)
                    matrix[row, 0] = 0;
        }
    }
}