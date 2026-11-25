public static class PythagoreanTriplet
{
    public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
    {
         var result = new System.Collections.Generic.List<(int a, int b, int c)>();

        for (int a = 1; a < sum / 3; a++)
        {
            int numerator = sum * (sum - 2 * a);
            int denominator = 2 * (sum - a);

            if (numerator % denominator != 0)
            {
                continue;
            }

            int b = numerator / denominator;
            int c = sum - a - b;

            if (a < b && b < c)
            {
                result.Add((a, b, c));
            }
        }

        return result;
    }
}