using System;

class Program
{
    static void Main()
    {
        int decimalNumber = 25;

        string binaryResult = DecimalToBinary(decimalNumber);
        Console.WriteLine($"Decimal {decimalNumber} to binary: {binaryResult}");

        string binaryNumber = "11001";

        int decimalResult = BinaryToDecimal(binaryNumber);
        Console.WriteLine($"Binary {binaryNumber} to decimal: {decimalResult}");
    }

    static string DecimalToBinary(int decimalNumber)
    {
        return Convert.ToString(decimalNumber, 2);
    }

    static int BinaryToDecimal(string binaryNumber)
    {
        return Convert.ToInt32(binaryNumber, 2);
    }
}
