namespace Lab12;
public abstract class CustomLogger
{
    // implementam un lock pentru ca sa nu avem mai multe loggere accesand aceeasi resursa
    protected readonly object lockObj = new object();

    public abstract void Log(string message, LogCriticality criticality);
}
