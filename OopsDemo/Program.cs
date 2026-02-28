// access modifiers, default access modifiers, impact of modifers on inherihance

using System;
using System.Runtime.CompilerServices;
using System.Reflection;
using OopsDemo;
using OopsDemo2;


/*
List of Access Modifiers in C# and scope:
| Modifier               | Scope / Visibility Description                                           | Accessible From                                               |
| ---------------------- | ------------------------------------------------------------------------ | ------------------------------------------------------------- |
| **public**             | No restriction                                                           | Any class in any assembly                                     |
| **private**            | Only within the containing class                                         | Same class only                                               |
| **protected**          | Containing class + derived classes                                       | Same class and all subclasses (including in other assemblies) |
| **internal**           | Only within the same assembly                                            | Any code in the same project/assembly                         |
| **protected internal** | *Union*: protected **OR** internal (whichever allows access)             | Same assembly OR any subclass in any assembly                 |
| **private protected**  | *Intersection*: private **AND** protected (both conditions must be true) | Accessible only to subclasses **within the same assembly**    |

*/

//Only public and internal are allowed for top-level types (like class, interface at namespace level).
//Default is internal if no modifier is specified.
namespace OopsDemo
{
    //Only public and internal are allowed for top-level types (like class, interface at namespace level).
    //Default is internal if no modifier is specified.
    public class Program
    {
        public static void Main(string[] args)
        {
            //Default modifier internal for top-level classes, private for class members.
            Base b;

            b = new Derived();
            b.Show();

            b = new Derived2();
            b.Show();
            b.ShowAccessModifier();

            b = new Derived3();
            b.Show();
            b.ShowAccessModifier();

            b = new AnotherAssemblyClass();
            b.Show();
            b.ShowAccessModifier();

            b = new AnotherAssemblyDerivedClass();
            b.Show();
            b.ShowAccessModifier();

            b = new AnotherAssemblyDerived2Class();
            b.Show();
            b.ShowAccessModifier();
        }
    }

    abstract class Base
    {
        public int baseVariable = 5;
        protected int baseProtectedVariable = 5;

        private protected int basePrivateProtectedVariable = 5;
        protected internal int baseProtectedInternalVariable = 5;

        public virtual void Show()
        {
            Console.WriteLine($"Base: {baseVariable} - {baseProtectedVariable} - {basePrivateProtectedVariable} - {baseProtectedInternalVariable}");
        }
        public abstract void ShowAccessModifier();
    }

    class Derived : Base
    {
        //Default modifier internal for top-level classes, private for class members.
        public override void Show()
        {
            Console.WriteLine($"Derived: {baseVariable} - {baseProtectedVariable} - {basePrivateProtectedVariable} - {baseProtectedInternalVariable}");
        }

        // this method shows inpact of access modifiers in derived class
        public override void ShowAccessModifier()
        {
            Type type = typeof(Derived2);
            foreach (FieldInfo f in type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance))
            {
                System.Console.WriteLine($"Derived: {f.Name} = Public: {f.IsPublic}");
                System.Console.WriteLine($"Derived: {f.Name} = Private: {f.IsPrivate}");
                System.Console.WriteLine($"Derived: {f.Name} = Protected: {f.IsFamily}");
                System.Console.WriteLine($"Derived: {f.Name} = Internal: {f.IsAssembly}");
                System.Console.WriteLine($"Derived: {f.Name} = Protected Internal: {f.IsFamilyOrAssembly}");
                System.Console.WriteLine($"Derived: {f.Name} = = Private Internal: {f.IsFamilyAndAssembly}");
            }
        }
    }

    class Derived2 : Derived
    {
        public override void Show()
        {
            Console.WriteLine($"Derived2: {baseVariable} - {baseProtectedVariable} - {basePrivateProtectedVariable} - {baseProtectedInternalVariable}");
        }

        public override void ShowAccessModifier()
        {
            Type type = typeof(Derived2);
            foreach (FieldInfo f in type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance))
            {
                System.Console.WriteLine($"Derived2: {f.Name} = Public: {f.IsPublic}");
                System.Console.WriteLine($"Derived2: {f.Name} = Private: {f.IsPrivate}");
                System.Console.WriteLine($"Derived2: {f.Name} = Protected: {f.IsFamily}");
                System.Console.WriteLine($"Derived2: {f.Name} = Internal: {f.IsAssembly}");
                System.Console.WriteLine($"Derived2: {f.Name} = Protected Internal: {f.IsFamilyOrAssembly}");
                System.Console.WriteLine($"Derived2: {f.Name} = = Private Internal: {f.IsFamilyAndAssembly}");
            }
        }
    }
    class Derived3 : Derived
    {
        public override void Show()
        {
            Console.WriteLine($"Derived3: {baseVariable} - {baseProtectedVariable} - {basePrivateProtectedVariable} - {baseProtectedInternalVariable}");
        }
        public override void ShowAccessModifier()
        {
            Type type = typeof(Derived3);
            foreach (FieldInfo f in type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance))
            {
                System.Console.WriteLine($"Derived3: {f.Name} = Public: {f.IsPublic}");
                System.Console.WriteLine($"Derived3: {f.Name} = Private: {f.IsPrivate}");
                System.Console.WriteLine($"Derived3: {f.Name} = Protected: {f.IsFamily}");
                System.Console.WriteLine($"Derived3: {f.Name} = Internal: {f.IsAssembly}");
                System.Console.WriteLine($"Derived3: {f.Name} = Protected Internal: {f.IsFamilyOrAssembly}");
                System.Console.WriteLine($"Derived3: {f.Name} = Private Internal: {f.IsFamilyAndAssembly}");
            }
        }
    }
}


namespace OopsDemo2
{
    class AnotherAssemblyClass : Base
    {
        public override void Show()
        {
            Console.WriteLine($"AnotherAssemblyClass: {baseVariable} - {baseProtectedVariable} - {basePrivateProtectedVariable} - {baseProtectedInternalVariable}");
        }
        public override void ShowAccessModifier()
        {
            Type type = typeof(AnotherAssemblyClass);
            foreach (FieldInfo f in type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance))
            {
                System.Console.WriteLine($"AnotherAssemblyClass: {f.Name} = Public: {f.IsPublic}");
                System.Console.WriteLine($"AnotherAssemblyClass: {f.Name} = Private: {f.IsPrivate}");
                System.Console.WriteLine($"AnotherAssemblyClass: {f.Name} = Protected: {f.IsFamily}");
                System.Console.WriteLine($"AnotherAssemblyClass: {f.Name} = Internal: {f.IsAssembly}");
                System.Console.WriteLine($"AnotherAssemblyClass: {f.Name} = Protected Internal: {f.IsFamilyOrAssembly}");
                System.Console.WriteLine($"AnotherAssemblyClass: {f.Name} = Private Protected: {f.IsFamilyAndAssembly}");
            }
        }
    }
    class AnotherAssemblyDerivedClass : AnotherAssemblyClass
    {
        public override void Show()
        {
            Console.WriteLine($"AnotherAssemblyDerivedClass: {baseVariable} - {baseProtectedVariable} - {basePrivateProtectedVariable} - {baseProtectedInternalVariable}");
        }
        public override void ShowAccessModifier()
        {
            Type type = typeof(AnotherAssemblyClass);
            foreach (FieldInfo f in type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance))
            {
                System.Console.WriteLine($"AnotherAssemblyDerivedClass: {f.Name} = Public: {f.IsPublic}");
                System.Console.WriteLine($"AnotherAssemblyDerivedClass: {f.Name} = Private: {f.IsPrivate}");
                System.Console.WriteLine($"AnotherAssemblyDerivedClass: {f.Name} = Protected: {f.IsFamily}");
                System.Console.WriteLine($"AnotherAssemblyDerivedClass: {f.Name} = Internal: {f.IsAssembly}");
                System.Console.WriteLine($"AnotherAssemblyDerivedClass: {f.Name} = Protected Internal: {f.IsFamilyOrAssembly}");
                System.Console.WriteLine($"AnotherAssemblyDerivedClass: {f.Name} = Private Protected: {f.IsFamilyAndAssembly}");
            }
        }
    }

    class AnotherAssemblyDerived2Class : AnotherAssemblyDerivedClass
    {
        public override void Show()
        {
            Console.WriteLine($"AnotherAssemblyDerived2Class: {baseVariable} - {baseProtectedVariable} - {basePrivateProtectedVariable} - {baseProtectedInternalVariable}");
        }
        public override void ShowAccessModifier()
        {
            Type type = typeof(AnotherAssemblyClass);
            foreach (FieldInfo f in type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance))
            {
                System.Console.WriteLine($"AnotherAssemblyDerived2Class: {f.Name} = Public: {f.IsPublic}");
                System.Console.WriteLine($"AnotherAssemblyDerived2Class: {f.Name} = Private: {f.IsPrivate}");
                System.Console.WriteLine($"AnotherAssemblyDerived2Class: {f.Name} = Protected: {f.IsFamily}");
                System.Console.WriteLine($"AnotherAssemblyDerived2Class: {f.Name} = Internal: {f.IsAssembly}");
                System.Console.WriteLine($"AnotherAssemblyDerived2Class: {f.Name} = Protected Internal: {f.IsFamilyOrAssembly}");
                System.Console.WriteLine($"AnotherAssemblyDerived2Class: {f.Name} = Private Protected: {f.IsFamilyAndAssembly}");
            }
        }
    }
}