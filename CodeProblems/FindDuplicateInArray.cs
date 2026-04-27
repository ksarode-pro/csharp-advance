using System;

namespace CodeProblems;

public class FindDuplicateInArray
{
    internal static void FindDuplicateUsingDictionary(int[] a)
    {
        Dictionary<int, int> d = new Dictionary<int, int>();
        for (int i = 0; i < a.Length; i++)
        {
            if (!d.TryAdd(a[i], i))
                Console.WriteLine(a[i] + " is duplicate");
            // try
            // {
            //     //d[a[i]] = i; //checks and updates key; no error is thrown
            //     d.Add(a[i], i); //throws argument exception if duplicate key found
            // }
            // catch(ArgumentException e)
            // {
            //     System.Console.WriteLine(a[i] + "is duplicate");
            // }
        }

        // foreach(KeyValuePair<int, int> kv in d)
        // {
        //     System.Console.WriteLine(kv.Key + "-" + kv.Value);
        // }
    }


    internal static void FindDuplicateUsingHashSet(int[] a)
    {
        HashSet<int> h = new HashSet<int>();
        for (int i = 0; i < a.Length; i++)
        {
            if (!h.Add(a[i]))
                Console.WriteLine(a[i] + " is duplicate");
        }
    }

    internal static void FindDuplicateUsingLinq(int[] a)
    {
        int[] dups = a.GroupBy(e => e)
        .Where(g => g.Count() > 1)
        .Select(g => g.Key)
        .ToArray<int>();

        System.Console.WriteLine(string.Join(',', dups));
    }

    internal static void FindDuplicateUsingNoInBluitFunc(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            bool alreadyPrinted = false;

            for (int k = 0; k < i; k++)
            {
                if (numbers[k] == numbers[i])
                {
                    alreadyPrinted = true;
                    break;
                }
            }

            if (alreadyPrinted)
                continue;

            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[i] == numbers[j])
                {
                    Console.WriteLine(numbers[i]);
                    break;
                }
            }
        }

    }
}
