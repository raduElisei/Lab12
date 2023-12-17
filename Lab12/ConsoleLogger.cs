namespace Lab12;
public class ConsoleLogger : CustomLogger
{
    public override void Log(string message, LogCriticality criticality = LogCriticality.Information)
    {
        lock (lockObj)
        {
            ConsoleLogger consoleLogger = new ConsoleLogger();

            switch (criticality)
            {
                case LogCriticality.Information:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case LogCriticality.Warning:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case LogCriticality.High:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case LogCriticality.Critical:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
                default:
                    break;
            }

            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
