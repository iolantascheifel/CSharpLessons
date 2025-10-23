namespace ZooApp;

public class Giraffe: Animal, ICare
{
    public override void Eat()
    {
        base.Eat();
        Console.WriteLine("Giraffe is eating...");
    }

    public override void MakeSound()
    {
        Console.WriteLine("Giraffe's sound");
    }

    public void Care()
    {
       Console.WriteLine("Giraffe is sick and needs care");
    }
}