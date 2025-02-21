using System.Collections;

namespace Collections
{
    class SortedListDemo
    {
        public void Demo()
        {
            System.Console.WriteLine("NonGeneric collections\n------------SortedList------------");
            SortedList st = new SortedList();
            st.Add(5, "One");
            st.Add(9, 2);
            st.Add(2, new { Name = "Kiran", Age = 30 });
            st.Add(1, new { Name = "Pradnya", Age = 25 });
            st.Add(3, new { Name = "Shiv", Age = 2 });
            //duplicate addion
            //st.Add(3, new { Name = "Shiv", Age = 2 });
            //Unhandled exception. System.ArgumentException: Item has already been added. Key in dictionary: '3'  Key being added: '3'

            System.Console.WriteLine("Count: " + st.Count);
            System.Console.WriteLine("List elements:");
            foreach (DictionaryEntry element in st)
            {
                System.Console.WriteLine(element.Key + " : " + element.Value);
            }
            if (st.ContainsKey(1))
            {
                System.Console.WriteLine("Key 1 exists in the SortedList");
            }
            st.Remove(1);
        }
    }
}