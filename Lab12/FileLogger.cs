namespace Lab12;
public class FileLogger : CustomLogger
{
    public string filePath = @"C:\Users\David\Documents\Programare\Dotnet\FastTrackContacts\Lab12\Lab12\log.txt";

    public override void Log(string message, LogCriticality criticality)
    {
        lock (lockObj)
        {
            using (StreamWriter streamWriter = new StreamWriter(filePath))
            {
                streamWriter.WriteLine(criticality);
                streamWriter.WriteLine(message);
                streamWriter.Write("\n");
                streamWriter.Close();
            }
        }

    }
}
