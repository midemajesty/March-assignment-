using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of rows for the matrices:");
        int rows = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number of columns for the matrices:");
        int columns = int.Parse(Console.ReadLine());

        int[,] matrix1 = ReadMatrix(rows, columns, "first");
        int[,] matrix2 = ReadMatrix(rows, columns, "second");

        int[,] sumMatrix = AddMatrices(matrix1, matrix2);

        Console.WriteLine("Sum of the matrices:");
        PrintMatrix(sumMatrix);
    }

    static int[,] ReadMatrix(int rows, int columns, string name)
    {
        Console.WriteLine($"Enter elements for the {name} matrix:");
        int[,] matrix = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            string[] rowElements = Console.ReadLine().Split(' ');
            for (int j = 0; j < columns; j++)
            {
                matrix[i, j] = int.Parse(rowElements[j]);
            }
        }

        return matrix;
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static int[,] AddMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int columns = matrix1.GetLength(1);

        int[,] result = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        return result;
    }
}
