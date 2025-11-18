/*

<T> this is called parameterized types

Benefits of generic collections:
Type safety at compile time
No boxing/unboxing
Improved performance because boxing and unboxing not involved
IDE support (IntelliSense)

List<T>
-Holds elements as per insertion order. Non-Sorted
-Zero-based index
-Automatically resizes

Internal Working:
-Uses internal array that grows dynamically (doubling size usually). 
-When Capacity is exceeded, it resizes.
*/


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

            lt.Add(5);
            lt.Add(2);
            //duplicate addion
            lt.Add(2);
            lt.Add(3);
            lt.Add(4);
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