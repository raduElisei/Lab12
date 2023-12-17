namespace Lab12;
public class DBLogger : CustomLogger
{
    string connectionString = string.Empty;
    public override void Log(string message, LogCriticality criticality)
    {
        lock (lockObj)
        {
        }
    }
}
