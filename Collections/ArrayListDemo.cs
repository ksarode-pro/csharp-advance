using System.Collections;
namespace Collections
{
    class ArrayListDemo
    {
        public void Demo()
        {
            Console.WriteLine("Hello, Collections!\n======================");
            System.Console.WriteLine("NonGeneric collections\n------------ArrayList------------");
            ArrayList list = new ArrayList();
            System.Console.WriteLine("Capacity: " + list.Capacity);
            list.Add(1);
            list.Add(2);
            //duplicate addion
            list.Add(2);
            list.Add("Three");
            list.Add(new { Name = "Kiran", Age = 30 });
            list.Add(new { Name = "Pradnya", Age = 25 });
            list.Add(new { Name = "Shiv", Age = 2 });
            System.Console.WriteLine("Count: " + list.Count);
            System.Console.WriteLine("Capacity: " + list.Capacity);
            System.Console.WriteLine("List elements:");
            foreach (var element in list)
            {
                System.Console.WriteLine(element);
            }
            list.Remove(2);
            list.RemoveAt(2);
            if (list.Contains(1))
            {
                System.Console.WriteLine("1 exists in the list");
            }
        }
    }
}