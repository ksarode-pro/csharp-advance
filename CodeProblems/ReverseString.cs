using System.Runtime.InteropServices;

namespace CodeProblems
{
    class ReverseString
    {
        internal void ReverseStringNormal(string s)
        {
            string sReverse = new string(s.Reverse().ToArray());
                        
            System.Console.WriteLine($"Reverse of {s} is {sReverse}");
        }

        internal void ReverseStringWithoutInBluildFunctions(string s)
        {
            char[] revChars = new char[s.Length];
            for(int i = (s.Length - 1), j = 0; i >= 0; i--, j++)
            {
                revChars[j] = s[i];
            }

            System.Console.WriteLine($"Reverse of {s} is {new string(revChars)}");
        }

        internal string ReverseStringRecurssive(string s)
        {
            if (s.Length <= 1)
            {
                return s;
            }
            
            return s[s.Length - 1] + ReverseStringRecurssive(s.Substring(0, s.Length - 1));
        }       
    }
}
