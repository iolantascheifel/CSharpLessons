namespace OOPAgain;

public interface IEmployee
{
    string Name { get; set; }
    int Salary { get; set; }
    string CompanyName { get; set; }
    void Work();
}