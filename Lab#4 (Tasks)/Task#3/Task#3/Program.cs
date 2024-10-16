using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input = "This is a simple example to demonstrate word extraction.";

        string[] result = ExtractWords(input);

        Console.WriteLine("Words with Length 4 to 5 containing vowels:");
        foreach (string word in result)
        {
            Console.WriteLine(word);
        }
    }

    static string[] ExtractWords(string input)
    {
        string[] words = input.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        List<string> filteredWords = new List<string>();
        string vowels = "aeiouAEIOU";

        foreach (string word in words)
        {
            if (word.Length >= 4 && word.Length <= 5 && ContainsVowel(word, vowels))
            {
                filteredWords.Add(word);
            }
        }

        return filteredWords.ToArray();
    }

    static bool ContainsVowel(string word, string vowels)
    {
        foreach (char letter in word)
        {
            if (vowels.Contains(letter))
            {
                return true;
            }
        }
        return false;
    }
}
