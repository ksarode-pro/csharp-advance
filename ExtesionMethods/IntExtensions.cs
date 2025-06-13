namespace EntesionMethods;

//Example of extention method on value type
public static class IntExtensions
{
    public static bool IsEven(this int number)
    {
        return number % 2 == 0;
    }
}