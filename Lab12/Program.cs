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
    }
}
