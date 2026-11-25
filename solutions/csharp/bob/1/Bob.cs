public static class Bob
{
    public static string Response(string statement)
    {
        var s = statement.Trim();
        if (s.Length == 0)
            return "Fine. Be that way!";
        var isQuestion =  s.EndsWith('?');
        var isYelling =s.Any(char.IsLetter) && !s.Any(char.IsLower);

        if (isYelling && isQuestion)
            return "Calm down, I know what I'm doing!";
        if(isYelling)
            return "Whoa, chill out!";
        if (isQuestion)
            return "Sure.";
        return "Whatever.";
    }
}