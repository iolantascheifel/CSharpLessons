namespace OOPAgain;

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student(24, TypeOfStudies.Courses)
        {
            Name = "Mark",
            GroupName = "whatever",
            Gender = "male",
        };
        student.Study();
        student.Study(["math", "literature", "biology"]);
        student.Eat();
        student.IntroduceYourself();
        Console.WriteLine($"{student.Name}, {student.StudyLevel}, {student.TypeOfStudies} {student.Gender},  {student.Nationality}");

        student.Move();
        
        Human human = student;
        human.IntroduceYourself();
        human.Move();

        // SpaceX spaceX = new SpaceX();
        // Souz souz = new Souz();
        //
        // RocketStation rocketStation = new RocketStation();
        // rocketStation.StartRocket(souz);
        // rocketStation.StartRocket(spaceX);

    }
}