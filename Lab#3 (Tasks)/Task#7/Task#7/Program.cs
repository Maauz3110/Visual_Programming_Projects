using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter third number:");
        int num3 = Convert.ToInt32(Console.ReadLine());

        int smallest = Math.Min(num1, Math.Min(num2, num3));
        Console.WriteLine($"The smallest number is: {smallest}");
    }
}
