namespace EntesionMethods
{
    public static class StringUtil
    {
        public static int CountWords(this string str)
        {
            return str.Split(' ').Length;
        }

        public static int CountChars(this string str)
        {
            return str.Length;
        }
    }
}
