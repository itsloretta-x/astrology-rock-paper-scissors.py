public static class Pangram
{
    public static bool IsPangram(string input)
    {
      var seen = new bool[26];
        int count = 0;

        foreach (char c in input)
        {
            char lower = char.ToLowerInvariant(c);
            if (lower >= 'a' && lower <= 'z')
            {
                int i = lower - 'a';
                if (!seen[i])
                {
                    seen[i] = true;
                    count++;
                }
            }
        }

        return count == 26;  
    }
}
