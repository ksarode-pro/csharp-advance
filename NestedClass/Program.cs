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
            OuterPublicClass.InnerNonStaticClass inner = new OuterPublicClass.InnerNonStaticClass();
            inner.display();

            //Inner private class members - you need to access them using method of outer class due to private accessibility.
            OuterPublicClass outer = new OuterPublicClass();
            outer.AccessPrivateClassMember();
        }
    }


    //Outer public class
    public class OuterPublicClass
    {
        //Inner static class
        public static class InnerStaticClass
        {
            public static void display()
            {
                System.Console.WriteLine("This is display method from static class");
            }
        }
        //Inner non-static class
        public class InnerNonStaticClass
        {
            public void display()
            {
                System.Console.WriteLine("This is display method from non-static class");
            }
        }
        //Inner private class
        private class InnerPrivateClass
        {
            public void display()
            {
                System.Console.WriteLine("This is display method from private class");
            }
        }

        public void AccessPrivateClassMember()
        {
            InnerPrivateClass inner = new InnerPrivateClass();
            inner.display();
        }
    }
}