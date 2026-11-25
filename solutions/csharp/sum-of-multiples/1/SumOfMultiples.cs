public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
       var bases = new System.Collections.Generic.List<int>(multiples);
        int total = 0;

        for (int n = 1; n < max; n++)
        {
            foreach (int m in bases)
            {
                if (m != 0 && n % m == 0)
                {
                    total += n;
                    break;
                }
            }
        }

        return total;  
    }
}