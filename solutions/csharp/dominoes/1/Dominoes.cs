public static class Dominoes
{
    public static bool CanChain(IEnumerable<(int, int)> dominoes)
    {
      var degree = new System.Collections.Generic.Dictionary<int, int>();
        var parent = new System.Collections.Generic.Dictionary<int, int>();

        int Find(int x)
        {
            while (parent[x] != x)
            {
                parent[x] = parent[parent[x]];
                x = parent[x];
            }
            return x;
        }

        foreach (var (a, b) in dominoes)
        {
            foreach (int v in new[] { a, b })
            {
                if (!parent.ContainsKey(v))
                {
                    parent[v] = v;
                    degree[v] = 0;
                }
                degree[v]++;
            }

            int ra = Find(a);
            int rb = Find(b);
            if (ra != rb)
            {
                parent[ra] = rb;
            }
        }

        if (parent.Count == 0)
        {
            return true;
        }

        foreach (var d in degree.Values)
        {
            if (d % 2 != 0)
            {
                return false;
            }
        }

        int root = -1;
        foreach (int v in parent.Keys)
        {
            int r = Find(v);
            if (root == -1)
            {
                root = r;
            }
            else if (r != root)
            {
                return false;
            }
        }

        return true;  
    }
}