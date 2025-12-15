using Semaphor.Homework;

namespace Semaphor;

class Program
{
    static void Main(string[] args)
    {
        // Theater theater = new Theater();
        // theater.StartAct();
        
        var ivanov = new Teacher("Ivanov");
        var petrov = new Teacher("Petrov");
        var sidorov = new Teacher("Sidorov");
        
        var math = new Subject("Math", ivanov);
        var physics = new Subject("Physics", petrov);
        var programming = new Subject("Programming", sidorov);

        var students = Enumerable.Range(1, 10)
            .Select(id => new Student(id))
            .ToList();

        Console.WriteLine("Exam started...\n");

        Parallel.ForEach(students, student =>
        {
            student.PassExam(math);
            student.PassExam(physics);
        });

        Console.WriteLine("\nExam finished.\n");
    }
}