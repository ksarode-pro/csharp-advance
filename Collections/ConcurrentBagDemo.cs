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
            ConcurrentBag<int> cb = new ConcurrentBag<int>();

            cb.Add(1);
            cb.Add(2);
            //duplicate addion
            cb.Add(2);
            cb.Add(3);

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