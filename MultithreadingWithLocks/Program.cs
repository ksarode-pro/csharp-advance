using System;
using System.Threading;

namespace MultithreadingWithLocks
{
    class Program
    {
        static int counter = 0;
        static object lockObj = new object();

        public async static Task Main(string[] args)
        {
            Task t = Task.Run(IncreamentCounter);
            Task t2 = Task.Run(IncreamentCounter);
            Task t3 = Task.Run(IncreamentCounter);
            await t;
            await t2;
            await t3;
            System.Console.WriteLine(counter);
        }

        private static void IncreamentCounter()
        {
            lock(lockObj)
            {
                for (int i = 0; i < 100000; i++)
                {
                    counter++;
                }
            }
        }
    }
}