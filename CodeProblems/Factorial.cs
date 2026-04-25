namespace CodeProblems
{
    class Factorial
    {
        internal void FactorialNormal(int n)
        {
            int fact = 1;
            for(int i = n; i > 0; i--)
            {
                fact *= i; 
            }
            System.Console.WriteLine($"Factorial of {n} is {fact}.");
        }


        internal int FactorialRecurssive(int n)
        {
            //recursive part - keep calling function
            if(n > 1)
            {
                return n * FactorialRecurssive(n - 1);            
            }
            else
            {
                //base part - ends recursion
                return 1;
            }
                
        }       
    }
}