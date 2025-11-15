namespace ZooApp;

public class Lion: Animal, IFeedable, ICareable
{
    public override void MakeSound()
    {
        Console.WriteLine("Lion's sound");
    }

    public void Feed()
    {
        Console.WriteLine("Lion is eating");
    }

    public void Care()
    {
        Console.WriteLine("Take care of Lions");
    }
}