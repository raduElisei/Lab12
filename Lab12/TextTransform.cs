using System.Text;

namespace Lab12;

internal class TextTransformer
{
    private StringBuilder textBuilder;

    private TextTransformer(string initialText)
    {
        textBuilder = new StringBuilder(initialText);
    }

    public static TextTransformer FromString(string initialText)
    {
        return new TextTransformer(initialText);
    }

    public TextTransformer ReplaceSubstring(string oldSubstring, string newSubstring)
    {
        textBuilder.Replace(oldSubstring, newSubstring);
        return this;
    }

    public TextTransformer ConvertToUppercase()
    {
        textBuilder = new StringBuilder(textBuilder.ToString().ToUpper());
        return this;
    }

    public TextTransformer ConvertToLowercase()
    {
        textBuilder = new StringBuilder(textBuilder.ToString().ToLower());
        return this;
    }

    public TextTransformer DeleteSubstring(string substring)
    {
        textBuilder.Replace(substring, string.Empty);
        return this;
    }

    public TextTransformer InsertSubstring(int position, string substring)
    {
        if (position >= 0 && position <= textBuilder.Length)
        {
            textBuilder.Insert(position, substring);
        }
        else
        {
            Console.WriteLine($"Position {position} is invalid.");
        }

        return this;
    }

    public void PrintString()
    {
        Console.WriteLine(textBuilder.ToString());
    }
}
