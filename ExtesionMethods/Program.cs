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
            int[] demoArray = new int[] { 1, 1, 1, 1 };
            Console.WriteLine(numbers.SumOfElements());
            Console.WriteLine(demoArray.SumOfElements());

            //chainnig of extension methods
            string text = "hello world";
            Console.WriteLine(text.ToTitleCase().AddPrefix("Title: "));

            //extension method for Employee (custom type)
            Employee emp = new Employee { Name = "John", Salary = 60000 };
            Console.WriteLine(emp.IsGreaterThan50K());

            string description = "This is a test description";
            System.Console.WriteLine(description.CountWords());
            System.Console.WriteLine(description.CountChars());

            //extension method for double
            double fahrenheit = 98.6;
            Console.WriteLine($"Fahrenheit: {fahrenheit}, Celsius: {fahrenheit.ToCelsius()}");
            Console.WriteLine($"Celsius: {fahrenheit.ToCelsius()}, Fahrenheit: {fahrenheit.ToCelsius().ToFahrenheit()}");

            //Extention method on IEnumerable<int>
            int[] array = [1, 2, 3, 4, 5];
            foreach (int x in array.reverseArray())
            {
                System.Console.WriteLine(x);
            }
        }
    }
}
