namespace ZooApp;

public class Keeper: Employee
{
    public override void Work(Animal animal)
    {
        Console.WriteLine($"Keeper is playing with {animal.Name}");
    }
}