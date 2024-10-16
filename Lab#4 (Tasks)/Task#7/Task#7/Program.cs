using System;

class Program
{
    static void Main()
    {
        int[,] matrixA = new int[3, 3];
        int[,] matrixB = new int[3, 3];
        int[,] resultMatrix = new int[3, 3];

        Console.WriteLine("Enter the elements of Matrix A:");
        InputMatrix(matrixA);

        Console.WriteLine("Enter the elements of Matrix B:");
        InputMatrix(matrixB);

        resultMatrix = MultiplyMatrices(matrixA, matrixB);

        Console.WriteLine("Resultant Matrix after multiplication (A × B):");
        DisplayMatrix(resultMatrix);
    }

    static void InputMatrix(int[,] matrix)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Enter element [{i + 1}, {j + 1}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    static int[,] MultiplyMatrices(int[,] matrixA, int[,] matrixB)
    {
        int[,] resultMatrix = new int[3, 3];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    resultMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }

        return resultMatrix;
    }

    static void DisplayMatrix(int[,] matrix)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
