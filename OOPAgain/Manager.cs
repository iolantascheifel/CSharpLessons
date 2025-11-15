namespace OOPAgain;

public class Manager: Employee
{
    public Manager()
    {
        Salary = 10000;
    }
    public override void Work()
    {
        Console.WriteLine($" Manager {Name},  Salary: {Salary}");
    }
}