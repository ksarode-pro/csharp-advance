public class Employee
{
    public string Name { get; set; }
    public int Salary { get; set; }
}

public static class EmployeeExtensions
{
    public static bool IsGreaterThan50K(this Employee emp, int threshold = 50000)
    {
        return emp.Salary > threshold;
    }
}