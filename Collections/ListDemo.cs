using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class ListDemo
    {
        public void Demo()
        {
            System.Console.WriteLine("Generic collections\n------------List<T,V>------------");
            List<int> lt = new List<int>();

            lt.Add(1);
            lt.Add(2);
            //duplicate addion
            lt.Add(2);
            lt.Add(3);

            System.Console.WriteLine("Count: " + lt.Count);
            System.Console.WriteLine("List elements:");
            foreach (var element in lt)
            {
                System.Console.WriteLine(element);
            }
            if (lt.Contains(1))
            {
                System.Console.WriteLine("Key 1 exists in the Hashtable");
            }
            lt.Remove(1);
        }
    }
}