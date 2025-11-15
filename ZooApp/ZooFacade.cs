namespace ZooApp;

public class ZooFacade
{
    private readonly ZooBuilder _builder = new();
    private ZooManager _zoo;

    public void BuildDefaultZoo()
    {
        _zoo = _builder
            .AddAnimal("penguin", "Петя", 3)
            .AddAnimal("penguin", "Катя", 2)
            .Build();
    }

    public void FeedAllAnimals()
    {
        _zoo?.FeedAnimals();
    }

    public void ShowReport()
    {
        Console.WriteLine("=== Zoo Report ===");
        Console.WriteLine("Все животные накормлены и ухожены.");
    }
}