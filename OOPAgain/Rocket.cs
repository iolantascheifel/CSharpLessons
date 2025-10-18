namespace OOPAgain;

public abstract class Rocket: IRocket
{
    public string Name { get; }
    public int Volume { get; set; }
    public abstract void Prepare();
    public abstract void Launch();
    public abstract void Finish();

    public Rocket(string name, int volume)
    {
        Name = name;
        Volume = volume;
    }
}