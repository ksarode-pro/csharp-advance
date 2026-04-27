using System;

namespace CodeProblems;

public class PrimeNumber
{
    internal static bool IsPrime(int number)
    {
        //number less than 2 including -ve are not prime
        if(number < 2)
            return false;

        for(int i = 2; i * i <= number; i++)
        {
            if(number % i == 0)
                return false;   
        }
        return true;
    }
}
