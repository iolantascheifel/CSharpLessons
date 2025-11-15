namespace ZooApp;

public class RobotCleanerAdapter : ICareable
{
    private readonly RobotCleaner _robot;

    public RobotCleanerAdapter(RobotCleaner robot)
    {
        _robot = robot;
    }

    public void Care()
    {
        _robot.Clean(); 
    }
}