
/*
17 

[17, 1, 55, 5, 10, 12, 6]
*/

public static class TwoSumProblem
{
    static internal (int a, int b) Findlements(int[] a, int target)
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

    static internal (int a, int b) Findlements2(int[] a, int target)
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
}