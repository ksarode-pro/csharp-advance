namespace MethosOverridingAndHiding
{
    class Employee
    {
        public virtual void PrintFullName()
        {
            System.Console.WriteLine("Base Class PrintFullName Method");
        }
    }

    class FullTimeEmployee : Employee
    {
        public override void PrintFullName()
        //public new void PrintFullName()
        {
            System.Console.WriteLine("Derived Class PrintFullName Method");
        }
    }
}