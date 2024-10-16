using System;

class Program
{
    static void Main()
    {
        int[] responses = { 1, 2, 3, 4, 5, 3, 2, 1, 4, 3, 2, 5, 1, 3, 4, 2, 1, 5, 3, 4,
                            1, 2, 4, 3, 2, 5, 1, 4, 3, 2, 1, 5, 2, 3, 4, 2, 1, 3, 5, 4 };

        int[] frequency = new int[5];

        foreach (int response in responses)
        {
            if (response >= 1 && response <= 5)
            {
                frequency[response - 1]++;
            }
        }

        for (int i = 0; i < frequency.Length; i++)
        {
            Console.WriteLine($"Response {i + 1} given by: {frequency[i]} people");
        }
    }
}
