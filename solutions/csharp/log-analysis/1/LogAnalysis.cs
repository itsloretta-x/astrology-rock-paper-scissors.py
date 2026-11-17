public static class LogAnalysis 
{
    public static string SubstringAfter(this string str, string delimeter)
    {  
        return str[(str.IndexOf(delimeter)+ delimeter.Length)..];
    }
    public static string SubstringBetween(this string str, string leftDelimeter, string rightDelimeter)
    {  
    int start = str.IndexOf(leftDelimeter) + leftDelimeter.Length;
        int end = str.IndexOf(rightDelimeter, start);
        return str[start..end];
    }
    public static string Message(this string str)
    {
        return str.SubstringAfter(":").Trim();
    }
    public static string LogLevel(this string str)
    {
        return str.SubstringBetween("[","]");
    }
}