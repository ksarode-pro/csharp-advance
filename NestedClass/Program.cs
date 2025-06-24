using System;

namespace NestedClassDemo
{
    class Program
    {
        public static void Main(string[] arg)
        {
            //Inner static class members
            OuterPublicClass.InnerStaticClass.display();

            //Inner non-static class members
            OuterPublicClass outer = new OuterPublicClass();
            OuterPublicClass.InnerNonStaticClass inner = new OuterPublicClass.InnerNonStaticClass();
            inner.display(outer);

            //Inner private class members - you need to access them using method of outer class due to private accessibility.
            outer.AccessPrivateClassMember();
        }
    }


    //Outer public class
    public class OuterPublicClass
    {
        static int outerStaticClassMember = 10;
        int outerNonStaticClassMember = 10;

        //Inner static class
        public static class InnerStaticClass
        {
            public static void display()
            {
                System.Console.WriteLine("This is display method from static class = " + outerStaticClassMember);
            }
        }
        //Inner non-static class
        public class InnerNonStaticClass
        {
            public void display(OuterPublicClass o)
            {
                System.Console.WriteLine("This is display method from non-static class = " + o.outerNonStaticClassMember);
            }
        }
        //Inner private class
        private class InnerPrivateClass
        {
            public void display(int x)
            {
                System.Console.WriteLine("This is display method from private class = " + x);
            }
        }

        //inner private class can be access only with public method of outer class
        public void AccessPrivateClassMember()
        {
            InnerPrivateClass inner = new InnerPrivateClass();
            inner.display(this.outerNonStaticClassMember);
        }
    }
}