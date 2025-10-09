namespace OOPAgain;

public class Student: IStudent
{
    public required string Name { get; init; }
    
    public int Age { get; private set; }
    
    public string GroupName { get; set; }
    public TypeOfStudies TypeOfStudies { get; private set; }
    public int StudyLevel { get; private set; }

    public Student(int age)
    {
        Age = age;
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