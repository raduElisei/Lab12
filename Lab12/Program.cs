namespace Lab12;

internal class Program
{
    static void Main(string[] args)
    {
        string exampleString = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut" +
            " labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip" +
            " ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur." +
            " Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";

        var transformer = TextTransformer.FromString(exampleString);
        transformer
            .ReplaceSubstring("Lorem", "mamaliga")
            .DeleteSubstring("laborum")
            .ConvertToUppercase();

        transformer.PrintString();

        List<int> list = new List<int>();

        Console.WriteLine("Da numere de la tastatura:");

        Console.WriteLine(list.Count);

        for (int i = 0; i < 5; i++)
        {
            var readNumber = Console.ReadLine();
            if (readNumber == "")
            {
                continue;
            }
            list.Add(Convert.ToInt32(readNumber));
        }

        Console.WriteLine(list.Count);

        if (list.Count <= 0)
        {
            LogHelper.Log(LogTarget.Console, LogCriticality.Warning, $"List {nameof(list)} length is less than or equal to 0");
        }
        if (list.Any(number => number < 0))
        {
            LogHelper.Log(LogTarget.File, LogCriticality.Critical, $"There are negative elements in list {nameof(list)}");
        }
    }
}
