namespace OOPAgain;

public class SpaceX: Rocket
{
    public SpaceX() : base("SpaceX", 3000)
    {
        
    }

    public void GetFreeWifi()
    {
        Console.WriteLine("FreeWifi");
    }
    public override void Prepare()
    {
       Console.WriteLine("SpaceX Preparing..");
    }

    public override void Launch()
    { 
        Console.WriteLine("SpaceX Launching..");
    }

    public override void Finish()
    {
      Console.WriteLine("SpaceX Finishing..");
    }
}