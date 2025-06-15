public class Employee
{
    public string Name { get; set; }
    public int Salary { get; set; }
}

//Example of extention method on custom reference type
public static class EmployeeExtensions
{
    public static bool IsGreaterThan50K(this Employee emp, int threshold = 50000)
    {
        return emp.Salary > threshold;
    }

    public static double SumOfSalary(this IEnumerable<Employee> employees)
    {
        double TotalSum = 0;
        employees.Sum(e => TotalSum += e.Salary);
        return TotalSum;
    }
}