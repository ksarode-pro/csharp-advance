using System.Diagnostics.Contracts;

namespace Static
{
    class Program
    {
        public static void Main(String[] args)
        {
            System.Console.WriteLine("Hello");

            //called using Class Name
            StaticClass.Display();
            StaticClass.Counter = 1;
            System.Console.WriteLine(StaticClass.Counter);
        }
    }

    //Static class
    /*
    Characteristics:
        Cannot create objects
        Contains only static members
        Cannot have constructors except static constructor
    */
    static class StaticClass
    {
        //compile time error: cannot declare instance members in a static class
        //int counter;
        static int counter;

        /*
        A static constructor initializes static data.
        Characteristics:
            Executes only once when Static class members is accessed for the first time.
            Called automatically
            No access modifier allowed
            No parameters allowed
        */
        static StaticClass()
        {
            counter++;
        }

        //static properties
        internal static int Counter {
            get
            {
                return counter;
            } 
            set
            {
                counter++;
                counter += value;
            }
        } 

        internal static void Display()
        {
            //Keyword 'this' is not valid in a static property, static method, or static field initializer
            //System.Console.WriteLine(this.counter);
            System.Console.WriteLine(counter);
        }
    }
}