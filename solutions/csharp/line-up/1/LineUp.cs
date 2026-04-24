public static class LineUp
{
    public static string Format(string name, int number) =>
        $"{name}, you are the {number}{(number%100) switch 
            {
                11 or 12 or 13 => "th",
                _ => (number%10) switch {
                1 => "st",
                2 => "nd",
                3 => "rd",
                _ => "th"
                        }
                }
            } customer we serve today. Thank you!";
    
}
