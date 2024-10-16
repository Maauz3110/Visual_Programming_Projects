using System;

class Program
{
    static void Main()
    {
        int[,] marks =
        {
            { 92, 81, 66, 71, 80, 74, 85, 79, 91, 77 },
            { 75, 82, 94, 87, 90, 71, 88, 84, 73, 95 },
            { 79, 95, 77, 79, 84, 91, 92, 86, 85, 87 },
            { 72, 89, 82, 90, 87, 79, 97, 94, 81, 90 },
            { 86, 84, 88, 91, 76, 80, 81, 88, 86, 89 }
        };

        Console.WriteLine("Student  1   2   3   4   5   6   7   8   9  10");
        Console.WriteLine("------------------------------------------------");

        for (int i = 0; i < marks.GetLength(0); i++)
        {
            Console.Write($"Test {i + 1}   ");
            for (int j = 0; j < marks.GetLength(1); j++)
            {
                Console.Write($"{marks[i, j],3} ");
            }
            Console.WriteLine();
        }

        Console.Write("Avg.      ");
        for (int j = 0; j < marks.GetLength(1); j++)
        {
            int sum = 0;
            for (int i = 0; i < marks.GetLength(0); i++)
            {
                sum += marks[i, j];
            }
            int average = sum / marks.GetLength(0);
            Console.Write($"{average,3} ");
        }
        Console.WriteLine();
    }
}
