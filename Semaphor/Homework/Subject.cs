namespace Semaphor.Homework;

public class Subject
{
    public string Name { get; }
    public Teacher Teacher { get; }

    public Subject(string name, Teacher teacher)
    {
        Name = name;
        Teacher = teacher;
    }
}