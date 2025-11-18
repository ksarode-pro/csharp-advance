using System;
using System.Collections.Concurrent;

namespace Collections;

public class BlockingCollectionDemo
{
    public void Demo()
    {
        Console.WriteLine("Concurrent collections\n------------BlockingCollection<T>------------");

        using var bc = new BlockingCollection<int>(boundedCapacity: 10);

        // Producer task (signals completion itself)
        var producer = Task.Run(() =>
        {
            for (int i = 0; i < 10; i++)
            {
                // Blocks if full; will throw if CompleteAdding() has been called
                bc.Add(i);
                Console.WriteLine($"Produced: {i}");
            }

            // Signal that no more items will be added
            bc.CompleteAdding();
        });

        // Consumer (enumerates until adding completed and collection emptied)
        var consumer = Task.Run(() =>
        {
            foreach (var item in bc.GetConsumingEnumerable())
            {
                Console.WriteLine($"Consumed: {item}");
                // simulate work: Thread.Sleep(50);
            }
        });

        Task.WaitAll(producer, consumer);
    }

}
