﻿// See https://aka.ms/new-console-template for more information
using System.Collections;
namespace Collections;

class Program
{
    static void Main(string[] args)
    {
        ArrayListDemo al = new ArrayListDemo();
        al.Demo();

        HashtableDemo ht = new HashtableDemo();
        ht.Demo();

        SortedListDemo st = new SortedListDemo();
        st.Demo();

        ListDemo lt = new ListDemo();
        lt.Demo();

        DictionaryDemo dt = new DictionaryDemo();
        dt.Demo();

        GenericSortedListDemo gst = new GenericSortedListDemo();
        gst.Demo();
    }
}