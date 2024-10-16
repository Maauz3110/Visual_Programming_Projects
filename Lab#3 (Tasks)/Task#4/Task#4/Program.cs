using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number to calculate its factorial:");
        int number = Convert.ToInt32(Console.ReadLine());
        long result = Factorial(number);
        Console.WriteLine($"Factorial of {number} is: {result}");
    }

    static long Factorial(int num)
    {
        if (num == 0) return 1;
        long fact = 1;
        for (int i = 1; i <= num; i++)
        {
            fact *= i;
        }
        return fact;
    }
}
