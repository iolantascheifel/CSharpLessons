namespace OOPAgain;

public class Souz: Rocket
{
    public Souz() : base("Coюз", 2000)
    {
    }

    public override void Prepare()
    {
        Console.WriteLine("Cоюз подготавливается");
    }

    public override void Launch()
    {
       Console.WriteLine("Союз запускается");
    }

    public override void Finish()
    {
        Console.WriteLine("Союз останавливается");
    }
}