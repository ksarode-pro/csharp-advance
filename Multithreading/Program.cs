// Modern approach using Async programming and ThreadPool managed .NET
using System;
using System.Threading;

namespace Multithreading
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Thread t = new Thread(() => {
                for (int i = 1; i <= 10; i++)
                {
                    System.Console.WriteLine($"Worker Thread {i}");
                    Thread.Sleep(150);
                }
            });

            t.Start();

            for(int i = 1; i <= 3; i++)
            {
                System.Console.WriteLine("Tick...");
                Thread.Sleep(100);
            }

            t.Join();

            Console.ReadKey();    
        }    
    }
}


/*
// Old approach by directly managing Thread
using System;
using System.Threading;

namespace Multithreading
{
    public class ModernApproach
    {
        public static async Task Main(string[] args)
        {
            Task t = Task.Run(async () => {
                for (int i = 1; i <= 10; i++)
                {
                    System.Console.WriteLine($"Worker Thread {i}");
                    await Task.Delay(100);
                }
            });

            for(int i = 1; i <= 5; i++)
            {
                System.Console.WriteLine("Tick...");
                await Task.Delay(150);
            }

            await t;
        }    
    }
}
*/

