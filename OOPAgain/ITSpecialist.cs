namespace OOPAgain;

public class ITSpecialist: Employee
{
    public ITSpecialist()
    {
        Salary = 50000;
    }
    public override void Work()
    {
        Console.WriteLine($" ITSpecialst {Name},  Salary: {Salary}");
    }
}