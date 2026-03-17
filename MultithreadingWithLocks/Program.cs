using System;
using System.Threading;

/*
In .NET / C#, lock and Interlocked are both used for thread synchronization, but they solve different kinds of problems.

Think of it like this:

lock → protects a block of code1

Interlocked → performs atomic operations on variables
*/

namespace MultithreadingWithLocks
{
    class Program
    {
        static int counter = 0;
        private static object lockObj = new object();

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
            /*
                lock ensures that only one thread at a time can execute a block of code.
                Internally it uses Monitor.Enter / Monitor.Exit.
                
                Equivalent code:
                Monitor.Enter(_lockObj);
                try
                {
                    counter++;
                }
                finally
                {
                    Monitor.Exit(_lockObj);
                }
            */
            lock (lockObj)
            {
                for (int i = 0; i < 100000; i++)
                {
                    counter++;
                }
            }
        }
    }
}

