namespace CustomLogger;

public class FileLoggerDecorator: LoggerDecorator
{
    private FileLogger _fileLogger;
    
    public FileLoggerDecorator(ILogger logger, string path) : base(logger)
    {
        _fileLogger = new FileLogger(path);
    }

    public override void Log(string message)
    {
       _fileLogger.Log(message);
       _logger.Log(message);
    }
}