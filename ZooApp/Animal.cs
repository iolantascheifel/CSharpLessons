namespace ZooApp;

public class Animal: IAnimal
{
    public string Name { get; set; }
    public int Age { get; set; }
    public List<string> Species { get; set; }
    public bool IsHungry { get; set; }

    public void Eat()
    {
        IsHungry = false;
    }
}