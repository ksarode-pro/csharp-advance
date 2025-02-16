using System;

namespace Events
{
    // Step 1: Define a delegate type for the event
    public delegate void Notify(string message);

    // Step 2: Create a class that declares an event
    public class Process
    {
        // Declare an event using the delegate
        public event Notify ProcessCompleted;

        public void StartProcess()
        {
            Console.WriteLine("Process started...");
            System.Threading.Thread.Sleep(2000); // Simulate some work

            // Step 3: Raise the event (if there are subscribers)
            ProcessCompleted?.Invoke("Process completed successfully!");
        }
    }

    class Program
    {
        // Event handler method
        static void OnProcessCompleted(string message)
        {
            Console.WriteLine("Event Received: " + message);
        }

        static void Main()
        {
            Process process = new Process();

            // Step 4: Subscribe to the event
            process.ProcessCompleted += OnProcessCompleted;

            // Start the process
            process.StartProcess();
        }
    }
}
