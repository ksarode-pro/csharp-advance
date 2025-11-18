/*

Hashtable

Key/value pair collection
Keys must be unique
Non-generic
No type safety

Queue

FIFO (First In First Out)

Queue queue = new Queue();
queue.Enqueue("A");
queue.Dequeue();


Stack

LIFO (Last In First Out)

Stack stack = new Stack();
stack.Push("A");
stack.Pop();

*/


using System.Collections;

namespace Collections
{
    class HashtableDemo
    {
        public void Demo()
        {
            System.Console.WriteLine("NonGeneric collections\n------------Hashtable------------");
            Hashtable ht = new Hashtable();

            ht.Add(1, "One");
            ht.Add("2", 2);
            ht.Add(3, new { Name = "Kiran", Age = 30 });
            //duplicate addion
            //ht.Add(3, new { Name = "Kiran", Age = 30 });
            //Unhandled exception. System.ArgumentException: Item has already been added. Key in dictionary: '3'  Key being added: '3'

            System.Console.WriteLine("Count: " + ht.Count);
            System.Console.WriteLine("List elements:");
            foreach (DictionaryEntry element in ht)
            {
                System.Console.WriteLine(element.Key + " : " + element.Value);
            }
            if (ht.ContainsKey(1))
            {
                System.Console.WriteLine("Key 1 exists in the Hashtable");
            }
            ht.Remove(1);
        }
    }
}