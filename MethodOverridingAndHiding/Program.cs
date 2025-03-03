// See https://aka.ms/new-console-template for more information
using MethosOverridingAndHiding;

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
//
// In case of virtual-override, the method to be called 
// is determined by the object type and not by the reference type.

