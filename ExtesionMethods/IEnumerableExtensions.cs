namespace EntesionMethods;

public static class IEnumerableExtensions
{
    public static int SumOfElements(this IEnumerable<int> numbers)
    {
        return numbers.Sum();
    }
}