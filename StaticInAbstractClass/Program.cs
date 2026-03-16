using System;
using System.Configuration.Assemblies;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

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
            AbstractClass.StaticMethod(totallyDifferentClass);
            TotallyDifferentClass.ShowGenericTypeName<Derived>();
        }
    }

    //an abstract type cannot be sealed or static

    abstract class AbstractClass
    {
        internal static int counter = -1;
        public AbstractClass()
        {
            counter++;
            System.Console.WriteLine("This is Abhstract class conctructor");
        }

        //static constructor runs before the first access.
        static AbstractClass()
        {
            counter++;
        }

        public static void IncreaseCounter()
        {
            counter++;
            System.Console.WriteLine(counter);
        }

        public static void StaticMethod(TotallyDifferentClass totalyDifferentClass)
        {
            //Try to use object of another class in static method of abstract class
            totalyDifferentClass.DifferentClassMethod();
        }
    }
    class Derived : AbstractClass
    {
        //calling constructor of abstract class
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

        internal void DifferentClassMethod()
        {
            System.Console.WriteLine("Static method can call other class method using object");
        }

        //Non-Static class can have static members
        //Static members can be generic too
        internal static void ShowGenericTypeName<T>()
        {
            System.Console.WriteLine("Name of generic type is : " + typeof(T));
        }
    }




    /*
        Static class Characteristics:
            Cannot create objects
            Contains only static members
            Cannot have constructors except static constructor    
            Static Class CANNOT implement an Interface
    */
    //Static classes cannot be inherited.
    //Because: Static classes cannot be instantiated
    //Inheritance requires object creation

    class StaticClass
    {

    }

}



/*
1. What happens if a static constructor throws an exception?

If a static constructor fails, the type becomes unusable for the lifetime of the application.

Example:

class Test
{
    static Test()
    {
        throw new Exception("Error");
    }
}

Result:
Any attempt to access the class will throw TypeInitializationException.
*/

/*
2. When exactly does a static constructor run?

A static constructor runs before the first use of the class, such as:

First object creation

First static member access

Example:

Test.x

or

new Test()
*/

/*
5. Can static variables be garbage collected?

Usually No, because:
They live for the lifetime of the AppDomain
Memory is released only when the application ends
This is why excessive static usage can lead to memory leaks.
*/

/*
8. Are static methods faster than instance methods?
Slightly, because:
No object creation
No instance lookup
*/

/*
Static vs Dependency Injection
6. Why can't Dependency Injection work with static classes?
Because DI containers create instances.
Static classes:
cannot be instantiated
cannot be injected.
*/