namespace EntesionMethods;

public static class StringExtensions
{
    public static bool IsPalindrome(this string str)
    {
        string reversed = new string(str.ToCharArray().Reverse().ToArray());
        return str.Equals(reversed, StringComparison.OrdinalIgnoreCase);
    }

    //below 2 methods are added to demonstrate chaining of extension methods
    public static string ToTitleCase(this string str)
    {
        return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
    }

    public static string AddPrefix(this string str, string prefix)
    {
        return prefix + str;
    }
}