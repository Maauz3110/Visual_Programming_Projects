﻿using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Addition: {num1 + num2}");
        Console.WriteLine($"Subtraction: {num1 - num2}");
        Console.WriteLine($"Multiplication: {num1 * num2}");

        if (num2 != 0)
        {
            Console.WriteLine($"Division: {num1 / num2}");
        }
        else
        {
            Console.WriteLine("Division by zero is not allowed.");
        }
    }
}
