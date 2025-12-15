namespace Semaphor.Homework;

public class Student
{
    public int Id { get; }
    public Dictionary<Subject, ExamStatus> ExamStatuses { get; }

    public Student(int id)
    {
        Id = id;
        ExamStatuses = new Dictionary<Subject, ExamStatus>();
    }
    
    private void PrepareForExam(Subject subject)
    {
        ExamStatuses[subject] = ExamStatus.Preparing;
        Console.WriteLine($"Student {Id} is preparing for {subject.Name}");
        Thread.Sleep(2000);
    }

    public void PassExam(Subject subject)
    {
        PrepareForExam(subject);

        ExamStatuses[subject] = ExamStatus.InProgress;

        subject.Teacher.TakeExam(this, subject);
        
        if (ExamStatuses[subject] == ExamStatus.Passed)
            Console.WriteLine($"Student {Id} PASSED the exam: {subject.Name}");
        else
            Console.WriteLine($"Student {Id} FAILED the exam: {subject.Name}");
       
    }
}