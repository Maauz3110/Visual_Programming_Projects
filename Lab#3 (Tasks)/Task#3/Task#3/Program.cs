using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter temperature in Fahrenheit:");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());
        double centigrade = (fahrenheit - 32) * 5 / 9;
        Console.WriteLine($"Temperature in Centigrade: {centigrade}");
    }
}
