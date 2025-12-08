/*

Concurrent collections — deeper dive
------------------------------------
What they are (quick)?
- Concurrent collections live in System.Collections.
Concurrent and provide thread-safe, ready-to-use data structures 
(e.g., ConcurrentDictionary, ConcurrentQueue, ConcurrentStack, 
ConcurrentBag, BlockingCollection). 

Use them when multiple threads need to read/write the same collection 
without you writing lock logic.


How they achieve thread-safety (internals summary)?
- Some collections (like ConcurrentQueue and ConcurrentStack) 
avoid locks and use atomic primitives (Interlocked/CAS) for operations — 
this gives low-latency, lock-free behavior for common ops. 

- ConcurrentDictionary uses fine-grained locking/striping internally to allow high concurrency without locking the entire table.

- ConcurrentBag uses thread-local storage to make per-thread operations very fast; items are occasionally migrated between threads when necessary.

*/


using System.Collections.Concurrent;

namespace Collections
{
    class ConcurrentDictionaryDemo
    {
        public void Demo()
        {
            System.Console.WriteLine("Concurrent collections\n------------ConcurrentDictionary<T,V>------------");
            //sorts elements by key
            ConcurrentDictionary<int, string> cb = new ConcurrentDictionary<int, string>();

            cb.AddOrUpdate(11, "One", (key, oldValue) => "One");
            cb.AddOrUpdate(12, "2", (key, oldValue) => "2");
            cb.AddOrUpdate(3, "30", (key, oldValue) => "30");
            //duplicate key addion NOT allowed, replace the old value
            cb.AddOrUpdate(13, "40", (key, oldValue) => "40");
            cb.TryAdd(0, "40");
            //duplicate key addion NOT allowed, skips key insertion
            cb.TryAdd(11, "out string value");

            System.Console.WriteLine("Count: " + cb.Count);
            System.Console.WriteLine("List elements:");
            foreach (var element in cb)
            {
                System.Console.WriteLine(element);
            }
            if (cb.ContainsKey(1))
            {
                System.Console.WriteLine("Key 1 exists in the ConcurrentDictionary");
            }

            Console.WriteLine(cb.GetOrAdd(1, "One"));
            System.Console.WriteLine(cb.Remove(1, out string value));
            System.Console.WriteLine("Item removed: " + value);

            Console.WriteLine(cb.GetOrAdd(1, "One"));
            if (cb.ContainsKey(1))
            {
                System.Console.WriteLine("Key 1 exists in the ConcurrentDictionary");
            }

        }
    }
}