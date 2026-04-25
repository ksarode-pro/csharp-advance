using System.Data;
using System.IO.Pipes;

namespace ReadOnlyConst
{
    public class Program
    {
        //not allowed as a local variable; only field
         //Runtime constant, value is defined either with declaration or in constructor defination
        //usecase: confidurations that may change
        private readonly string  _connectionString;

        //readonly only protects reference of reference types
        private readonly Person _person1 = new Person();//allowed initialization ONLY while declaration and in constructor; later not allowed;
        
        public Program(string conn)
        {
            this._connectionString = conn;
            this._person1 = new Person {
                Name = "Kiran",
                Age = 36,
                Gender = true
            }; //allowed initialization ONLY while declaration and in constructor; later not allowed;
        }
        
        //usecase: universal truth that will neven change
        //compile time constants
        //value must be defined inline with declaration
        //implicitly static
        const float PI = 3.14F;
            
        public static void Main(String[] args)
        {
            
            //allowed as local variable and field
            const int DAYS_IN_WEEK = 7;

            //compilor replaces PI with 3.14 at compile time
            //eg Console.WriteLine(3.14);
            System.Console.WriteLine(PI);

            Program p = new Program("server=localhost;database=Study;username=sa;password=Testing@123;TrustedConnection=true;");
            System.Console.WriteLine(p._connectionString);
            
            //VALUE TYPE: error CS0191: A readonly field cannot be assigned to (except in a constructor or init-only setter of the type in which the field is defined or a variable initializer)
            //p._connectionString = "Trying to change";


            //FOR REFERENCE TYPE: error CS0191: A readonly field cannot be assigned to (except in a constructor or init-only setter of the type in which the field is defined or a variable initializer) 
            //p._person1 = new Person();
            
            //FOR REFERENCE TYPE: but modifications in object contents are allowed; Readonly protects object references not it's contents
            p._person1.Name = "Pradnya";
            System.Console.WriteLine(p._person1.Name);
            
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool Gender { get; set; }
    }
}