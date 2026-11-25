using System;
using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
     var sb = new StringBuilder();
        bool capitalizeNext = false;

        foreach (char c in identifier)
        {
            if (c == ' ')
            {
                sb.Append('_');
            }
            else if (char.IsControl(c))
            {
                sb.Append("CTRL");
            }
            else if (c == '-')
            {
                capitalizeNext = true;
            }
            else if (!char.IsLetter(c))
            {
                continue;
            }
            else if (c >= 'α' && c <= 'ω')
            {
                continue;
            }
            else
            {
                sb.Append(capitalizeNext ? char.ToUpper(c) : c);
                capitalizeNext = false;
            }
        }

        return sb.ToString();   
        
    }
}
