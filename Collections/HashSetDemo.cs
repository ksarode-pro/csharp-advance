using System.Collections;

namespace Collections
{
    class HashSetDemo
    {
        public void Demo()
        {
            System.Console.WriteLine("Generic collections\n------------HashSetDemo------------");
            HashSet<int> hs = new HashSet<int>();
            hs.Add(5);
            hs.Add(1);
            hs.Add(3);
            hs.Add(2);
            //duplicate addion
            hs.Add(2); //no error
            System.Console.WriteLine("Count: " + hs.Count);
            System.Console.WriteLine("List elements:");
            foreach (var element in hs)
            {
                System.Console.WriteLine(element);
            }
            if (hs.Contains(1))
            {
                System.Console.WriteLine("1 exists in the Hashset");
            }
            hs.Remove(1);
        }
    }
}