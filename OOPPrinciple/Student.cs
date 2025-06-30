namespace OOPPrinciple;

public class Student
{
    
    public required string FullName { get; init; }
    public required int Age { get; init; }
    public required TypeOfStudy TypeOfStudy { get; init; }
    public int StudyLevel { get; private set; }

    public Student()
    {
        
    }

    public Student(string fullName)
    {
        FullName = fullName;
    }

    public Student(string fullName, TypeOfStudy typeOfStudy)
    {
        FullName = fullName;
        TypeOfStudy = typeOfStudy;
    }
    
    public void Study()
    {
        Random randomizer = new Random();
        StudyLevel = randomizer.Next(1, 100);
    }
}