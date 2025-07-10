namespace OOPPrinciple;

public interface IPerson: IEatable, ISleepable, IWalkable
{
    string FullName { get; }
    int Age { get; }
    string Gender { get; init; }
}