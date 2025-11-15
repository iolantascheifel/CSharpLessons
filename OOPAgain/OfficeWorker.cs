namespace OOPAgain;

public class OfficeWorker: Employee
{
    public OfficeWorker()
    {
        Salary = 1000;
    }
    
    public override void Work()
    {
        Console.WriteLine($" Office worker {Name},  Salary: {Salary}");
    }
}