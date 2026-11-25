public static class LineUp
{
    public static string Format(string name, int number)
    {
       var suffix = (number % 100)switch{
               11 =>"th", 12 =>"th", 13 => "th",_ => (number % 10) switch {
                       1 => "st",
                       2 => "nd",
                       3 => "rd",
                      _ => "th"
               }
       };
        return $"{name}, you are the {number}{suffix} customer we serve today. Thank you!";
    }
}
