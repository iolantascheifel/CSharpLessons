namespace OOPAgain;

public abstract class Employee: IEmployee
{
    public string Name { get; set; }
    public int Salary { get; set; }
    public string CompanyName { get; set; }

    public abstract void Work();
}