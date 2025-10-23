namespace ZooApp;

public class Penguin: Animal
{
    public override void Eat()
    {
        base.Eat();
        Console.WriteLine("Penguin is eating...");
    }

    public override void MakeSound()
    {
        Console.WriteLine("Penguin's sound");
    }
}