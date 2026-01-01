namespace Events
{
    class PublisherMessage : EventArgs
    {
        public string? PublisherName { get; set; }
    }

    public delegate void Notification<PublisherMessage>(object sender, PublisherMessage args);

    class Publisher
    {
        public event Notification<PublisherMessage>? OnNotify;

        public void PublisherTask()
        {
            System.Console.WriteLine("Publisher started working..");
            Thread.Sleep(3000);
            System.Console.WriteLine("Publisher work finished, sending notification...");
            if (OnNotify != null)
            {
                OnNotify.Invoke(this, new PublisherMessage { PublisherName = "John" });
            }
            else
            {
                System.Console.WriteLine("No subscribers to notify.");
            }
        }
    }

    class Subscriber
    {
        public void Subscribe(Publisher publisher)
        {
            publisher.OnNotify += OnPublisherNotify;
        }

        public void OnPublisherNotify(object sender, PublisherMessage args)
        {
            System.Console.WriteLine($"Notification received from {args.PublisherName}");
        }
    }
}