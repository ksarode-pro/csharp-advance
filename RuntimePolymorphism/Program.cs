// See https://aka.ms/new-console-template for more information
using RuntimePolymorphism;

DerivedClass o = new DerivedClass();
o.PrintFullName();
// virtual-override  Output: Derived Class PrintFullName Method
// new Output: Derived Class PrintFullName Method


BaseClass o2 = new DerivedClass();
o2.PrintFullName();
//virtual-override Output: Derived Class PrintFullName Method
// new Output: Base Class PrintFullName Method

BaseClass o3 = new BaseClass();
o3.PrintFullName();
//virtual-override Output: Base Class PrintFullName Method
// new Output: Base Class PrintFullName Method

//In case of new keyword (method hiding), the method to be called 
// is determined by the reference type and not by the object type.

// In case of virtual-override, the method to be called 
// is determined by the object type and not by the reference type.


BaseClass o4 = new DerivedClass();
o4.GetAddress(); //method hiding with 'new' keyword. Reference is considered while choosing method to execute.


//method is virtual but not overrriden, base class's inherited version is called.
DerivedClass dobj = new DerivedClass();
dobj.GetSalary(); 
