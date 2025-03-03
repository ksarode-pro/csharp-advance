namespace MethosOverridingAndHiding
{
    class BaseClass
    {
        public virtual void PrintFullName()
        {
            System.Console.WriteLine("Base Class PrintFullName Method");
        }
    }

    class DerivedClass : BaseClass
    {
        //public override void PrintFullName()
        public new void PrintFullName()
        {
            System.Console.WriteLine("Derived Class PrintFullName Method");
        }
    }
}