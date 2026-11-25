public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
         var sb = new System.Text.StringBuilder();
        bool newWord = true;

        foreach (char c in phrase)
        {
            if (char.IsWhiteSpace(c) || c == '-')
            {
                newWord = true;
            }
            else if (char.IsLetter(c) && newWord)
            {
                sb.Append(char.ToUpper(c));
                newWord = false;
            }
        }

        return sb.ToString();
    }
}