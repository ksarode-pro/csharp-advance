namespace EntesionMethods
{
    class Program
    {
        static void Main()
        {
            string word = "Madam";
            Console.WriteLine(word.IsPalindrome());

            int num = 10;
            Console.WriteLine(num.IsEven());

            //extension method for IEnumerable
            List<int> numbers = new List<int> { 1, 2, 3, 4 };
            Console.WriteLine(numbers.SumOfElements());

            //chainnig of extension methods
            string text = "hello world";
            Console.WriteLine(text.ToTitleCase().AddPrefix("Title: "));

            //extension method for Employee (custom type)
            Employee emp = new Employee { Name = "John", Salary = 60000 };
            Console.WriteLine(emp.IsGreaterThan50K());
        }
    }
}
