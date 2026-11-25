public static class SaddlePoints
{
    public static IEnumerable<(int, int)> Calculate(int[,] matrix)
    {
        var result = new System.Collections.Generic.List<(int, int)>();
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                int value = matrix[r, c];
                bool isRowMax = true;
                bool isColMin = true;

                for (int k = 0; k < cols; k++)
                {
                    if (matrix[r, k] > value)
                    {
                        isRowMax = false;
                        break;
                    }
                }

                if (!isRowMax)
                {
                    continue;
                }

                for (int k = 0; k < rows; k++)
                {
                    if (matrix[k, c] < value)
                    {
                        isColMin = false;
                        break;
                    }
                }

                if (isColMin)
                {
                    result.Add((r + 1, c + 1));
                }
            }
        }

        return result;
    }
}
