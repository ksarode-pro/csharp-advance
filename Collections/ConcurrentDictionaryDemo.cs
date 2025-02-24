using System.Collections.Concurrent;

namespace Collections
{
    class ConcurrentDictionaryDemo
    {
        public void Demo()
        {
            System.Console.WriteLine("Concurrent collections\n------------ConcurrentDictionary<T,V>------------");
            ConcurrentDictionary<int, string> cb = new ConcurrentDictionary<int, string>();

            cb.AddOrUpdate(1, "One", (key, oldValue) => "One");
            cb.AddOrUpdate(2, "2", (key, oldValue) => "2");
            cb.AddOrUpdate(3, "30", (key, oldValue) => "30");
            //duplicate addion
            cb.AddOrUpdate(3, "40", (key, oldValue) => "40");

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