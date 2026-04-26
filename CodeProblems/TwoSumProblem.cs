
/*
17 

[17, 1, 55, 5, 10, 12, 6]
*/

public static class TwoSumProblem
{
    static internal (int a, int b) FindElements(int[] a, int target)
    {
        int sum;
        for(int i = 0; i < a.Length; i++)
        {            
            for(int j = i + 1; j < a.Length; j++)
            {
                sum = (a[i] + a[j]);
                if(sum > target)
                    continue;
                
                if(target == sum)
                {
                    return (i,j);
                }
            }
        }
        return (-1,-1);
    }

    static internal (int a, int b) FindElements2(int[] a, int target)
    {
        int requiredNumber;
        int requiredNumberIndex;
        for(int i = 0; i < a.Length; i++)
        {            
            requiredNumber = target - a[i];
            requiredNumberIndex = Array.IndexOf(a, requiredNumber);
            if(requiredNumberIndex > -1 && requiredNumberIndex != i)
            {
                return (i, requiredNumberIndex);
            }
        }
        return (-1,-1);
    }

    static internal (int a, int b) FindElements3(int[] a, int target)
    {
        int requiredNumber;
        //Key = Element; Value = index; 
        Dictionary<int, int> dicArray = new Dictionary<int, int>();

        for(int i = 0; i < a.Length; i++)
        {            
            requiredNumber = target - a[i];
            
            if(dicArray.ContainsKey(requiredNumber))
                return(dicArray[requiredNumber], i);
            
            //add after checking requiredNumber
            if(!dicArray.ContainsKey(a[i]))
                dicArray.Add(a[i], i);
        }
        return (-1,-1);
    }
}