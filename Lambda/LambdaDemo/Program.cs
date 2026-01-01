
using System.Threading.Tasks;

namespace LambdaDemo
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            //normal lambdas using delegates
            Func<int, int, int> add = (x, y) => x + y;
            System.Console.WriteLine(add(5, 5));

            Action<string> hello = (x) => System.Console.WriteLine(x);
            hello("Kiran");

            //passing lambda to higher order functions
            var numbers = new List<int> { 1, 2, 3, 4, 5 };
            ProcessList(numbers, n => n % 2 == 0);

            //Async lambdas
            Func<int, int, Task<int>> asyncLambda = async (x, y) =>
            {
                Task.Delay(3000);
                return x + y;
            };
            System.Console.WriteLine(await asyncLambda(5, 5));
        }

        //passing lambda to higher order functions
        static void ProcessList(List<int> list, Func<int, bool> condition)
        {
            foreach (var item in list)
            {
                if (condition(item))
                    Console.WriteLine(item);
            }
        }
    }
}




