namespace CrackingCodingInterview.ArraysAndStrings
{
    public class Q7
    {
        public void RotateMatrixS1(int[,] matrix)
        {
            if (matrix.Length == 0 || matrix.GetLength(0) != matrix.GetLength(1)) 
                return;

            // 4 X 4 -> 2 layer, 6 X 6 -> 3 layer
            for (int layer = 0; layer < matrix.GetLength(0) / 2; layer++)
            {
                // first element of the layer
                int first = layer;
                // last element of the layer
                int last = matrix.GetLength(0) - 1 - layer;

                for (int i = first; i < last; i++)
                {
                    int offset = i - first;

                    int top = matrix[first, i];

                    // left to top
                    matrix[first, i] = matrix[last - offset, first];

                    // bottom to left
                    matrix[last - offset, first] = matrix[last, last - offset];

                    // right to bottom
                    matrix[last, last - offset] = matrix[i, last];

                    // top to right
                    matrix[i, last] = top;
                }
            }
        }
    }
}