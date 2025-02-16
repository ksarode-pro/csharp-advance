using System;

namespace deleates_evets
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

        static void Main()
        {
            // Step 3: Instantiate the delegate
            DisplayMessage del = ShowMessage;

            // Step 3.a: Instantiate multicast delegate
            del += ShowMulticastDelegateMessage;

            // Step 4: Invoke the delegate
            del("Hello, Delegates!");
        }
    }
}
