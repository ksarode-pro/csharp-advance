/*

Dictionary<TKey, TValue>

Key-value pair storage
Fast lookups via hashing
Unique keys only

Internal Working:
Uses hash table logic. Keys are hashed to determine index bucket

*/


using System.Collections;

namespace Collections
{
    class DictionaryDemo
    {
        public void Demo()
        {
            System.Console.WriteLine("Generic collections\n------------Dictionary------------");
            Dictionary<int, string> ht = new Dictionary<int, string>();

            ht.Add(1, "One");
            ht.Add(2, "2");
            ht.Add(3, "30");
            //duplicate addion
            //ht.Add(3, "40");
            //Unhandled exception. System.ArgumentException: Item has already been added. Key in dictionary: '3'  Key being added: '3'

            System.Console.WriteLine("Count: " + ht.Count);
            System.Console.WriteLine("List elements:");
            foreach (KeyValuePair<int, string> element in ht)
            {
                System.Console.WriteLine(element.Key + " : " + element.Value);
            }
            if (ht.ContainsKey(1))
            {
                System.Console.WriteLine("Key 1 exists in the Dictionary");
            }
            ht.Remove(1);
        }
    }
}