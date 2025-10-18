namespace OOPAgain;

public class Student: Human, IStudent
{
    public string GroupName { get; set; }
    public TypeOfStudies TypeOfStudies { get; private set; }
    public int StudyLevel { get; private set; }

    public Student(int age): base(age)
    {
        TypeOfStudies = TypeOfStudies.University;
    }

    public Student(int age, TypeOfStudies typeOfStudies): this(age)
    {
        TypeOfStudies = typeOfStudies;
    }
    
    public void Study()
    {
        Random randomizer = new Random();
        StudyLevel = randomizer.Next(1, 100);
   
    }

    public void Study(string[] subjects)
    {
        foreach (string subject in subjects)
        {
            Console.WriteLine($"Student studies: {subject}");
            Study();
        }
    }

    public override void IntroduceYourself()
    {
        base.IntroduceYourself();
        Console.WriteLine($"My studies is : {TypeOfStudies}");
    }

    public override void Eat()
    {
        Console.WriteLine("Student ate");
    }

    public override void Sleep()
    {
        Console.WriteLine("Student slept");
    }

    public new void Move()
    {
        Console.WriteLine("Student moving..");
    }

    public void PassExam()
    {
        Study();
        if (StudyLevel > 56)
        {
            Age++;
            Console.WriteLine("Congratulations!");
        }
        else
        {
            Console.WriteLine("Try again!");
        }
    }
}