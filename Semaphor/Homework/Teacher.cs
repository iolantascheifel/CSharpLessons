namespace Semaphor.Homework;

public class Teacher
{
    private readonly SemaphoreSlim _semaphore =
        new SemaphoreSlim(1, 1);
    
    public string Name { get; }

    public Teacher(string name)
    {
        Name = name;
    }

    public void TakeExam(Student student, Subject subject)
    {
        _semaphore.Wait();

        try
        {
            Console.WriteLine($"Teacher {Name} examines student {student.Id}");
            Thread.Sleep(1500);

            bool passed = Random.Shared.Next(2) == 0;
            student.ExamStatuses[subject] =
                passed ? ExamStatus.Passed : ExamStatus.Failed;
        }
        finally
        {
            _semaphore.Release();
        }
    }
}