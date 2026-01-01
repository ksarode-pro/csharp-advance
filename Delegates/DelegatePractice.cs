using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Delegates
{
    public delegate int Calculate(int a, int b);

    public class DelegatePractice
    {
        public int Add(int a, int b)
        {
            System.Console.WriteLine("Add: I am called");
            return a + b;
        }

        public int Sub(int a, int b)
        {
            System.Console.WriteLine("Sub: I am called");
            return a - b;
        }

        public void DelDemo()
        {
            Calculate cal;// = Add;
            //System.Console.WriteLine("Addition is " + cal(5, 5));
            cal = Sub;
            //System.Console.WriteLine("Substraction is " + cal(5, 5));
            cal += Add;
            System.Console.WriteLine("Addition is " + cal(5, 5) + " Substraction is " + cal(10, 5));

        }
    }
}