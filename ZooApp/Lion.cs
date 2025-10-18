namespace ZooApp;

public class Lion: Animal
{
    public Lion(string name, int age, List<string> species, bool isHungry)
    {
        Name = name;
        Age = age;
        Species = species;
        IsHungry = isHungry;
    }
}