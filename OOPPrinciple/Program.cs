namespace OOPPrinciple;

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student("Adam Smith", TypeOfStudy.Courses)
        {
            Age = 18,
            TypeOfStudy = TypeOfStudy.University,
            FullName = "Вася Иванов"
        };
        // Console.WriteLine(student.FullName);
        student.Study();
        // Console.WriteLine(student.StudyLevel);
        student.Study();
        // Console.WriteLine(student.StudyLevel);
        
        Guid id = Guid.NewGuid();  // Создаёт новый уникальный GUID
        Console.WriteLine(id); 
    }
}