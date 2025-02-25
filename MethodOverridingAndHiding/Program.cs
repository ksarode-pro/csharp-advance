// See https://aka.ms/new-console-template for more information
using MethosOverridingAndHiding;

FullTimeEmployee fullTimeEmployee = new FullTimeEmployee();
fullTimeEmployee.PrintFullName();
// virtual-override  Output: Derived Class PrintFullName Method
// new Output: Derived Class PrintFullName Method


Employee employee = new FullTimeEmployee();
employee.PrintFullName();
//virtual-override Output: Derived Class PrintFullName Method
// new Output: Base Class PrintFullName Method

Employee employee2 = new Employee();
employee2.PrintFullName();
//virtual-override Output: Base Class PrintFullName Method
// new Output: Base Class PrintFullName Method

//In case of new keyword (method hiding), the method to be called 
// is determined by the reference type and not by the object type.
//
// In case of virtual-override, the method to be called 
// is determined by the object type and not by the reference type.

