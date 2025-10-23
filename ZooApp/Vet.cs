namespace ZooApp;

public class Vet: Employee
{
    public override void Work(Animal animal)
    {
        Console.WriteLine($"Vet is checking {animal.Name}");
    }
}