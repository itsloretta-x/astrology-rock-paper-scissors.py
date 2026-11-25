public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        var seen = new bool[26];

        foreach (char c in word)
        {
            char lower = char.ToLowerInvariant(c);
            if (lower >= 'a' && lower <= 'z')
            {
                int i = lower - 'a';
                if (seen[i])
                {
                    return false;
                }
                seen[i] = true;
            }
        }

        return true; 
    }
}
