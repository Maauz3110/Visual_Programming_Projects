using System;

class Program
{
    static void Main()
    {
        string[] words = { "hello", "and", "Welcome", "to", "this", "demo!" };

        string result = Merger(words);

        Console.WriteLine(result);
    }

    static string Merger(string[] words)
    {
        return string.Join(" ", words);
    }
}
