using System;
using CodeProblems;

Factorial factorial = new Factorial();
factorial.FactorialNormal(5);
Console.WriteLine($"Factorial of 5 is " + factorial.FactorialRecurssive(5));

ReverseString reverse = new ReverseString();
reverse.ReverseStringNormal("Kiran");
reverse.ReverseStringWithoutInBluildFunctions("Kiran");
reverse.ReverseStringWithStringBuilder("Kiran");
reverse.ReverseStringWithTwoWayPointers("Kiran");
Console.WriteLine($"Reverse of Kiran is " + reverse.ReverseStringRecurssive("Kiran"));

//RemoveDuplicateFromArray.RemoveDuplicate([1,2,3,4, 3, 1, 2]);
//RemoveDuplicateFromArray.RemoveDuplicateWithCollection([1,2,3,4, 3, 1, 2]);
//RemoveDuplicateFromArray.RemoveDuplicateWithoutInbuildFunctions([1,2,3,4, 3, 1, 2]);
RemoveDuplicateFromArray.RemoveDuplicateOptimizedWithoutInbuilt([1,2,3,4, 3, 1, 2]);

Console.WriteLine(TwoSumProblem.Findlements([17, 1, 55, 5, 10, 12, 6], 17));
Console.WriteLine(TwoSumProblem.Findlements2([17, 1, 55, 5, 10, 12, 6], 17));