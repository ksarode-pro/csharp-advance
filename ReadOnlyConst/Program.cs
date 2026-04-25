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
        
        public Program(string conn)
        {
            this._connectionString = conn;
        }
        
        //usecase: universal truth that will neven change
        //compile time constants
        //value must be defined inline with declaration
        //implicitly static
        const float PI = 3.14;
            
        public static void Main(String[] args)
        {
            
            //allowed as local variable and field
            const float DAYS_IN_WEEK = 3.14;

            //compilor replaces PI with 3.14 at compile time
            //eg Console.WriteLine(3.14);
            System.Console.WriteLine(PI);

            Program p = new Program("server=localhost;database=Study;username=sa;password=Testing@123;TrustedConnection=true;");
            System.Console.WriteLine(p._connectionString);
        }
    }
}