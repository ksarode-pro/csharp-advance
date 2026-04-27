namespace RuntimePolymorphism
{
    class BaseClass
    {
        //public <NO virtual KEYWORD> void PrintFullName() //error CS0506: 'DerivedClass.PrintFullName()': cannot override inherited member 'BaseClass.PrintFullName()' because it is not marked virtual, abstract, or override
        public virtual void PrintFullName()
        {
            System.Console.WriteLine("Base Class PrintFullName Method");
        }

        public virtual void GetAddress()
        {
            System.Console.WriteLine("Base Class GetAddress Method");
        }

        public virtual void GetSalary() //marked as virtual but no presence in derived class, no error, 
        {
            System.Console.WriteLine("Base Class GetAddress Method");
        }
    }

    class DerivedClass : BaseClass
    {
        public override void PrintFullName()
        {
            System.Console.WriteLine("Derived Class PrintFullName Method");
        }

        //public void GetAddress() //NO override KEYWORD, hinding with warning. no error
        public new void GetAddress()
        {
            System.Console.WriteLine("Derived Class GetAddress Method");
        }

        /*
        //Marked as virtual in base, but no presence in derived class (no hiding, no override) produces no error/warning. 
        // 
        public virtual void GetSalary() 
        {
            System.Console.WriteLine("Base Class GetAddress Method");
        }
        */
    }
}