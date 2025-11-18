using System;

namespace Collections;

public class LinkedListDemo
{
    public void Demo()
    {
        System.Console.WriteLine("Generic collections\n------------LinkedList------------");


        LinkedList<int> l = new LinkedList<int>();

        l.AddFirst(1);
        l.AddLast(5);
        l.AddBefore(l.Find(5), 4); //LinkedListNode class object as first parameter
        l.AddAfter(l.Find(5), 6);
        l.AddFirst(10);

        System.Console.WriteLine($"Total nodes - {l.Count}");

        foreach (int e in l)
        {
            System.Console.WriteLine(e);
        }
    }

}
