using System.Collections.Concurrent;
using System.ComponentModel;
using System.Runtime.InteropServices;
namespace Collections
{
    class ConcurrentBagDemo
    {
        public void Demo()
        {
            System.Console.WriteLine("Concurrent collections\n------------ConcurrentBag<T>------------");
            // does not sort the items
            ConcurrentBag<int> cb = new ConcurrentBag<int>();

            cb.Add(1);
            cb.Add(2);
            //duplicate addion allowed
            cb.Add(2);
            cb.Add(3);
            cb.Add(0);

            System.Console.WriteLine("Count: " + cb.Count);
            System.Console.WriteLine("List elements:");
            foreach (var element in cb)
            {
                System.Console.WriteLine(element);
            }
            if (cb.Contains(1))
            {
                System.Console.WriteLine("Key 1 exists in the ConcurrentBag");
            }
            //TryTake() is a thread-safe way to remove an item from the ConcurrentBag
            if (cb.TryTake(out int item))
            {
                System.Console.WriteLine("Item removed: " + item);
            }

            if (cb.TryTake(out int item2))
            {
                System.Console.WriteLine("Item removed: " + item2);
            }
        }
    }
}