namespace OOPPrinciple;

public abstract class Person: IPerson, IAnimal
{
    public string FullName { get; private set; }
    public int Age { get; protected set; }
    public required string Gender { get; init; }

    public Person(string fullName, int age)
    {
        FullName = fullName;
        Age = age;
    }

    void IAnimal.Eat()
    {
        Console.WriteLine($"Eating as animal{FullName}");
    }

    void IEatable.Eat()
    {
        Console.WriteLine($"Eating as person {FullName}");
    }

    public abstract void Sleep();

    public virtual void Walking()
    {
        Console.WriteLine("Walking");
    }

}