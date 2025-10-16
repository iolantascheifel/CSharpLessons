namespace ZooApp;

public class Lion: Animal
{
    public string Name { get; private set; }
    public int Age { get; private set; }
    public List<string> Species { get; private set; }
    public bool IsHungry { get; set; }

    public Lion(string name, int age, List<string> species, bool isHungry)
    {
        Name = "Lion";
        Age = 7;
        Species = species;
        IsHungry = isHungry;
    }
}