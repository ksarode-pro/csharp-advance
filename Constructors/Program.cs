/*
COPY
A copy constructor in C# is a constructor that creates a new object by copying the data from an existing object of the same class.
C# does not provide a built-in copy constructor (unlike C++), but you can manually define one.

Used to:
Duplicate an object with the same values
Create deep or shallow copies
Safely clone objects without exposing internal state

Shallow vs. Deep Copy
Shallow copy: Copies references as-is. If the object has reference-type fields, both objects share them.
Deep copy: Creates new instances of reference-type fields to avoid shared state.


PRIVATE
Private constructors are used in C# to restrict object creation from outside the class.
Key use cases:

Singleton Pattern
Ensures only one instance of a class exists.
public class Logger
{
    private static readonly Logger _instance = new Logger();
    private Logger() { }

    public static Logger Instance => _instance;
}

Factory Pattern
Prevents direct instantiation so objects must be created through controlled factory methods.
public class Employee
{
    private Employee() { }
    public static Employee Create(string name) => new Employee();
}

Static Classes
Static classes automatically have a private constructor to prevent instantiation.
public static class MathUtil
{
    // compiler adds private constructor
}

Prevent Instantiation of a Class Meant Only for Helpers
A class with only static members should not be instantiated.
public class Utils
{
    private Utils() { }  // prevents "new Utils()"
}

When You Want Only Specific Methods Inside the Class to Create Objects
Useful in domain-driven design and validation.
public class Order
{
    public int Quantity { get; }
    private Order(int qty) { Quantity = qty; }

    public static Order Create(int qty)
    {
        if (qty <= 0) throw new Exception("Invalid qty");
        return new Order(qty);
    }
}


*/

namespace Constructors
{
    class Program
    {
        public static void Main(string[] args)
        {
            NormalConstructor nc = new NormalConstructor();
            StaticConstructor sc = new StaticConstructor();
            //PrivateConstructor pc = new PrivateConstructor(); //'PrivateConstructor.PrivateConstructor()' is inaccessible due to its protection level

            Child pi = new Child();
            ParameterizedConstructor pc = new ParameterizedConstructor(5, 2);
            //ParameterizedConstructor pc2 = new ParameterizedConstructor();


            //Copy constructor
            Person kiran = new Person(new Person()
            {
                _age = 36,
                _name = "Kiran",
                _address = new Address
                {
                    line1 = "Add1",
                    line2 = "line2"
                }

            });
            kiran.Show();
        }
    }

    //Normal
    class NormalConstructor
    {
        public NormalConstructor()
        {
            System.Console.WriteLine("NormalConstructor called. Constractor has NO RETURN VALUE.");
        }
    }

    //ParameterizedConstructor
    class ParameterizedConstructor : NormalConstructor
    {
        //overloading
        // public ParameterizedConstructor()
        // {
        //     System.Console.WriteLine($"ParameterizedConstructor NO PARAM called.");
        // }
        public ParameterizedConstructor(int param1, int param2)
        {
            System.Console.WriteLine($"ParameterizedConstructor WITH PARAM called. param1: {param1} param1: {param2}");
        }
    }

    //Static
    class StaticConstructor
    {
        //access modifiers are not allowed on static constructors
        /*public static StaticConstructor()
        {
            
        }*/

        static StaticConstructor()
        {
            System.Console.WriteLine("StaticConstructor called. Constractor has NO RETURN VALUE and NO ACCESS MODIFIER");
        }
    }

    //Private
    class PrivateConstructor
    {
        private PrivateConstructor()
        {
            System.Console.WriteLine("PrivateConstructor called. Constractor has NO RETURN VALUE");
        }
    }

    //Parameterized Constructor
    class Child : ParameterizedConstructor
    {
        //inheriting from class having parameterized constructor only   
        public Child() : base(1, 2)
        {
            System.Console.WriteLine("CopyConstructor called. Constractor has NO RETURN VALUE and NO ACCESS MODIFIER");
        }
    }

    //Copy Constructor
    class Person
    {
        internal string _name;
        internal int _age;
        internal Address _address;
        //parameterless constructor is needed else you cannot create initial/first object of Person class
        // Person p1 = new Person { Name = "Kiran", Age = 30 }; //-> There is no argument given that corresponds to the required parameter 'p' of 'Person.Person(Person)'
        public Person() { }
        public Person(Person p)
        {
            //Copy work
            this._name = p._name;
            this._age = p._age;
            /*
            Shallow vs. Deep Copy
            Shallow copy: Copies references as-is. If the object has reference-type fields, both objects share them.
            Deep copy: Creates new instances of reference-type fields to avoid shared state.
            */
            //DeepCopy
            this._address = new Address
            {
                line1 = p._address.line1,
                line2 = p._address.line2
            };
        }

        public void Show()
        {
            System.Console.WriteLine($"{this._name}'s age is {this._age}");
        }
    }

    class Address
    {
        public string line1 { get; set; }
        public string line2 { get; set; }
    }
}