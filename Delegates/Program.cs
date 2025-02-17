using System;
using System.Collections.Concurrent;
using System.Runtime.ExceptionServices;

namespace Deleates
{
    // Step 1: Define a delegate
    delegate void DisplayMessage(string message);

    class Program
    {
        // Step 2: Create a method matching the delegate signature
        static void ShowMessage(string message)
        {
            Console.WriteLine("Message: " + message);
        }

        //Step2.a: Create another method matching the delegate signature; for multicast delegate example
        static void ShowMulticastDelegateMessage(string message)
        {
            Console.WriteLine("Multicast Delegate Message: " + message);
        }

        // Method defined for EventHandler delegate demonstration
        static void OnEvent(object sender, EventArgs e)
        {
            Console.WriteLine("Event triggered");
        }

        static void Main()
        {
            #region custom delegates
            // Step 3: Instantiate the delegate
            DisplayMessage del = ShowMessage;

            // Step 3.a: Instantiate multicast delegate
            del += ShowMulticastDelegateMessage;

            // Step 4: Invoke the delegate
            del("Hello, Delegates!");

            // Step 5: Remove a method from the delegate
            Console.WriteLine("Removing ShowMessage from the delegate");
            del -= ShowMessage;
            del("Hello, Kiran!");

            // Step 6: Using anonymous method
            System.Console.WriteLine("Using Anonymous Method with delegate");
            DisplayMessage anonymousDel = delegate (string message)
            {
                Console.WriteLine("Anonymous Message: " + message);
            };
            anonymousDel("Hello, Anonymous!");

            // Step 7: Using lambda expression
            System.Console.WriteLine("Using Lambda Expression with delegate");
            DisplayMessage lambdaDel = message => Console.WriteLine("Lambda Message: " + message);
            lambdaDel("Hello, Lambda!");
            #endregion

            #region inbuilt delegates
            // Step 8: Using Func delegate
            System.Console.WriteLine("Using Func delegate");
            //first 2 ints are inputs and 3rd int is output
            Func<int, int, int> add = (a, b) => a + b;
            Console.WriteLine("Addition: " + add(10, 20));

            // Step 9: Using Action delegate
            System.Console.WriteLine("Using Action delegate");
            Action<string> print = message => Console.WriteLine("Print Message: " + message);
            print("Hello, Action!");

            // Step 10: Using Predicate delegate
            System.Console.WriteLine("Using Predicate delegate");
            Predicate<string> isUpper = str => str.Equals(str.ToUpper());
            Console.WriteLine("IsUpper: " + isUpper("KIRAN"));

            // Step 11: Using EventHandler delegate
            System.Console.WriteLine("Using EventHandler delegate");
            var eventHandler = new EventHandler(OnEvent);
            eventHandler(null, EventArgs.Empty);
            #endregion

        }
    }
}
