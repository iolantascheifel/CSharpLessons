namespace ZooApp;

public class AnimalFactory
{
    public Animal CreateAnimal(string type, string name, int age)
    {
        return type.ToLower() switch
        {
            "penguin" => new Penguin { Name = name, Age = age },
            _ => throw new ArgumentException($"Unknown animal type: {type}")
        };
    }
}