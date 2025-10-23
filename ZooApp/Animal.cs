namespace ZooApp;

public class Animal: IAnimal
{
    public string Name { get; set; }
    public int Age { get; set; }
    public List<string> Species { get; set; }
    public bool IsHungry { get; set; }

    public virtual void Eat()
    {
        IsHungry = false;
    }

    public virtual void MakeSound()
    {
        Console.WriteLine("Animal is making sound...");
    }
}