namespace OOPPrinciple;

public class Student : Person
{
    public required TypeOfStudy TypeOfStudy { get; init; }
    public int StudyLevel { get; private set; }

    public Student(string fullName): base(fullName, 18)
    {
        StudyLevel = 50;
    }

    public Student(string fullName, TypeOfStudy typeOfStudy): base(fullName, 18)
    {
        TypeOfStudy = typeOfStudy;
    }

    public void PassExam()
    {
        if (StudyLevel > 60)
        {
            Age++;
            Console.WriteLine($"Сдал экзамен");
            return;
        }
        Console.WriteLine("Не повезло");
    }
    
    public void Study()
    {
        Random randomizer = new Random();
        StudyLevel = randomizer.Next(1, 100);
    }
    

    public override void Sleep()
    {
        Console.WriteLine("Sleeping in the dormitory");
    }

    public override void Walking()
    {
        Console.WriteLine("Walking in the park");
        base.Walking();
    }
}