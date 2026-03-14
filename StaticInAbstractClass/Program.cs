using System;

namespace StaticInAbstractClass
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine(AbstractClass.counter);
            Derived derived = new Derived();
            AbstractClass.IncreaseCounter();
            AbstractClass.IncreaseCounter();
            AbstractClass.IncreaseCounter();
            AbstractClass.IncreaseCounter();
            TotallyDifferentClass totallyDifferentClass = new TotallyDifferentClass();
        }
    }

    abstract class AbstractClass
    {
        internal static int counter = -1;
        public AbstractClass()
        {
            counter++; 
            System.Console.WriteLine("This is Abhstract class conctructor");
        }

        static AbstractClass()
        {
            counter++;   
        }

        public static void IncreaseCounter()
        {
            counter++;
            System.Console.WriteLine(counter);
        } 
    }

    class Derived : AbstractClass
    {
        public Derived() : base()
        {
            System.Console.WriteLine("This is Derived class conctructor");
        }
    } 

    class TotallyDifferentClass
    {
        public TotallyDifferentClass()
        {
            System.Console.WriteLine("TotallyDifferentClass is initialised");
            System.Console.WriteLine(AbstractClass.counter); 
        }
    }
}