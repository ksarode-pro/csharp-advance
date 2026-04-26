using System.ComponentModel.DataAnnotations;

namespace CodeProblems
{
    static class RemoveDuplicateFromArray
    {
        internal static void Display(int[] arr)
        {
            Array.ForEach(arr, el => Console.WriteLine(el));
        }

        internal static void RemoveDuplicate(int[] arr)
        {
            Display(arr.Distinct().ToArray());
        }

        internal static void RemoveDuplicateWithCollection(int[] arr)
        {
            Display(arr.ToHashSet().ToArray());
        }

        //[1, 2, 3, 4, 3, 1, 2]
        internal static void RemoveDuplicateWithoutInbuildFunctions(int[] arr)
        {
            List<int> unqArr = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (!isExist(unqArr, arr[i]))
                {
                    unqArr.Add(arr[i]);
                }
            }
            Display(unqArr.ToArray());
        }

        private static bool isExist(List<int> a, int el)
        {
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] == el)
                    return true;
            }
            return false;
        }

        // Input: [1, 2, 3, 4, 3, 1, 2]
        // Output: [1, 2, 3, 4]
        internal static void RemoveDuplicateOptimizedWithoutInbuilt(int[] arr)
        {
            int[] uniqueArr = new int[arr.Length];
            int uniqueCount = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                bool exists = false;

                for (int j = 0; j < uniqueCount; j++)
                {
                    if (uniqueArr[j] == arr[i])
                    {
                        exists = true;
                        break;
                    }
                }

                if (!exists)
                {
                    uniqueArr[uniqueCount] = arr[i];
                    uniqueCount++;
                }
            }

            for (int i = 0; i < uniqueCount; i++)
            {
                Console.WriteLine(uniqueArr[i]);
            }
        }

    }
}