namespace OOPAgain;

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student(24, TypeOfStudies.Courses)
        {
            Name = "Mark",
            GroupName = "whatever",
        };
        student.Study();
        Console.WriteLine($"{student.Name}, {student.StudyLevel}, {student.TypeOfStudies}");
        
        
  
    }
}