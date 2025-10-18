namespace OOPAgain;

public interface IRocket
{
    string Name { get; }
    int Volume {get; set;}
    void Prepare();
    void Launch();
    void Finish();
}