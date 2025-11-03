namespace ZooApp;

public class Penguin : Animal, IFeedable, ICareable
{
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} говорит: Ква!");
    }

    public void Feed()
    {
        Console.WriteLine($"{Name} ест рыбу.");
        IsHungry = false;
    }

    public void Care()
    {
        Console.WriteLine($"{Name} купается и чистит перья.");
    }
}