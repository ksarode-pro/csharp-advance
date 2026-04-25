using System;
using CodeProblems;

Factorial factorial = new Factorial();
factorial.FactorialNormal(5);
Console.WriteLine($"Factorial of 5 is " + factorial.FactorialRecurssive(5));

ReverseString reverse = new ReverseString();
reverse.ReverseStringNormal("Kiran");
reverse.ReverseStringWithoutInBluildFunctions("Kiran");
Console.WriteLine($"Reverse of Kiran is " + reverse.ReverseStringRecurssive("Kiran"));