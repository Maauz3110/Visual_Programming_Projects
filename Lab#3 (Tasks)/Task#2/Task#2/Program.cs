using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Square of {i}: {Square(i)}");
        }
    }

    static int Square(int number)
    {
        return number * number;
    }
}
