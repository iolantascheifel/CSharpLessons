namespace OOPPrinciple.RS;

public interface IRocket
{
    string Name { get; }
    int EnginePower { get; }
    void Check();
    void Start();
    void Stop();
}