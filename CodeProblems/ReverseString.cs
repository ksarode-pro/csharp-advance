using System.Runtime.InteropServices;
using System.Text;

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

        internal void ReverseStringWithStringBuilder(string s)
        {
            StringBuilder revChars = new StringBuilder();
            for(int i = (s.Length - 1); i >= 0; i--)
            {
                revChars.Append(s[i]);
            }

            System.Console.WriteLine($"Reverse of {s} is {revChars.ToString()}");
        }

        internal void ReverseStringWithTwoWayPointers(string str)
        {
            // char temp;
            StringBuilder s = new StringBuilder(str);
            for(int start = 0, end = (s.Length - 1); start < end; start++, end--)
            {
                //used tuple to eliiminate temp varibale
                (s[start],s[end]) = (s[end],s[start]);
                // temp = s[start];
                // s[start] = s[end];
                // s[end] = temp;   
            }

            System.Console.WriteLine($"Reverse is {s}");
        }

        internal string ReverseStringRecurssive(string s)
        {
            int inputLenght = s.Length;
            //base part - ends recursion
            if(inputLenght == 1)
            {
                System.Console.WriteLine(s);
                return s;
            }

            //recursive part - keep calling function
            System.Console.WriteLine(s[inputLenght - 1] + " + ReverseStringRecurssive(\"" + s.Substring(0, inputLenght - 1) + "\")");
            return s[inputLenght - 1] + ReverseStringRecurssive(s.Substring(0, inputLenght - 1));
        }       
    }
}
