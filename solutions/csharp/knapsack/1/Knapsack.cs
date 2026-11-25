public static class Knapsack
{
    public static int MaximumValue(int maximumWeight, (int weight, int value)[] items)
    {
      var best = new int[maximumWeight + 1];

        foreach (var item in items)
        {
            for (int w = maximumWeight; w >= item.weight; w--)
            {
                int candidate = best[w - item.weight] + item.value;
                if (candidate > best[w])
                {
                    best[w] = candidate;
                }
            }
        }

        return best[maximumWeight];  
    }
}
