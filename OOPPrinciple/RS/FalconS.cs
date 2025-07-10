namespace OOPPrinciple.RS;

public class FalconS: Rocket
{
    public FalconS() : base("FalconS", 1500)
    {
    }

    public override void Check()
    {
        Console.WriteLine("FalconS: Check");
    }

    public override void Start()
    {
        Console.WriteLine("FalconS: Start");
    }

    public override void Stop()
    {
        Console.WriteLine("FalconS: Stop");
    }
}