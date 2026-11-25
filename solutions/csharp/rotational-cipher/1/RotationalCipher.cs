public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        var sb = new System.Text.StringBuilder();

        foreach (char c in text)
        {
            if (c >= 'a' && c <= 'z')
            {
                sb.Append((char)('a' + (c - 'a' + shiftKey) % 26));
            }
            else if (c >= 'A' && c <= 'Z')
            {
                sb.Append((char)('A' + (c - 'A' + shiftKey) % 26));
            }
            else
            {
                sb.Append(c);
            }
        }

        return sb.ToString(); 
    }
}