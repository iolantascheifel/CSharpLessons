namespace OOPAgain;

public abstract class Human 
{
    public required string Name { get; init; }
    public int Age { get; protected set; }
    public string Nationality { get; init; } = "unspecified";
    public string Gender { get; init; } = "unspecified";

    public abstract void Eat();

    public abstract void Sleep();

    public virtual void IntroduceYourself()
    {
        Console.WriteLine($"My name is {Name}, my age is {Age}, my nationality is {Nationality}, my gender is {Gender}");
    }

    public void Move()
    {
        Console.WriteLine($"Human moving..");
    }

    public Human(int age)
    {
        Age = age;
    }
}