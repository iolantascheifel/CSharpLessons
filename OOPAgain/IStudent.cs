namespace OOPAgain;

public interface IStudent
{
    string GroupName { get; set; }
    TypeOfStudies TypeOfStudies { get; }
    int StudyLevel { get; }
    void Study();
    void PassExam();
}