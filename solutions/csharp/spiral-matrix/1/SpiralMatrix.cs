public class SpiralMatrix
{
    public static int[,] GetMatrix(int size)
    {
     var matrix = new int[size, size];
        int top = 0, bottom = size - 1, left = 0, right = size - 1;
        int n = 1;

        while (top <= bottom && left <= right)
        {
            for (int c = left; c <= right; c++)
            {
                matrix[top, c] = n++;
            }
            top++;

            for (int r = top; r <= bottom; r++)
            {
                matrix[r, right] = n++;
            }
            right--;

            if (top <= bottom)
            {
                for (int c = right; c >= left; c--)
                {
                    matrix[bottom, c] = n++;
                }
                bottom--;
            }

            if (left <= right)
            {
                for (int r = bottom; r >= top; r--)
                {
                    matrix[r, left] = n++;
                }
                left++;
            }
        }

        return matrix;   
    }
}
