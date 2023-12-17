namespace Lab12;
public static class LogHelper
{
    private static CustomLogger logger = null;
    public static void Log(LogTarget target, LogCriticality criticality, string message)
    {
        switch (target)
        {
            case LogTarget.File:
                logger = new FileLogger();
                logger.Log(message, criticality);
                break;
            case LogTarget.Database:
                logger = new DBLogger();
                logger.Log(message, criticality);
                break;
            case LogTarget.Console:
                logger = new ConsoleLogger();
                logger.Log(message, criticality);
                break;
            default:
                return;
        }
    }
}
