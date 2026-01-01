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
            // Process process = new Process();
            // // Step 4: Subscribe to the event
            // process.ProcessCompleted += OnProcessCompleted;
            // // Start the process
            // process.StartProcess();

            // #region Stock Price Change Event
            // // Stock price change event sample application
            // //Google stock creation
            // Stock google = new Stock("Google", 1000);

            // //Investors creation
            // Investor investor1 = new Investor("Investor 1");
            // Investor investor2 = new Investor("Investor 2");

            // //Subscribing to the OnStockPriceChange event
            // google.OnPriceChanged += investor1.OnStockPriceChanged;
            // google.OnPriceChanged += investor2.OnStockPriceChanged;

            // //Changing the stock price
            // google.ChangePrice(1100);
            // #endregion

            #region Event with Custom EventArgs
            Publisher publisher = new Publisher();
            Subscriber subscriber = new Subscriber();
            subscriber.Subscribe(publisher);
            publisher.PublisherTask();
            #endregion
        }
    }
}
