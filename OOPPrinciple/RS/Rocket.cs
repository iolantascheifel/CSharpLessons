namespace OOPPrinciple.RS;

public abstract class Rocket: IRocket
{
    public string Name { get; }
    public int EnginePower { get; }
    public abstract void Check();
    public abstract void Start();
    public abstract void Stop();

    public Rocket(string name, int enginePower)
    {
        Name = name;
        EnginePower = enginePower;
    }
}