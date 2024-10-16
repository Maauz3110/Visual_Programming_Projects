using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter number of students:");
        int n = Convert.ToInt32(Console.ReadLine());

        double totalMarks = 0;
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Enter marks for student {i}:");
            totalMarks += Convert.ToDouble(Console.ReadLine());
        }

        double average = totalMarks / n;
        Console.WriteLine($"Average marks of the class: {average}");
    }
}
