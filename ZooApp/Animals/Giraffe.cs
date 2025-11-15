namespace ZooApp;

public class Giraffe: Animal, IFeedable, ICareable
{
    public override void MakeSound()
    {
        Console.WriteLine("Giraffe's sound");
    }

    public void Care()
    {
       Console.WriteLine("Giraffe is sick and needs care");
    }

    public void Feed()
    {
        Console.WriteLine("Giraffe is eating");
    }
}