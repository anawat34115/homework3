using System;

class Program
{
    static void Main()
    {
        while(true){

        Console.WriteLine("Enter operation (+ or -):");
        string operation = Console.ReadLine();


        if (operation != "+" && operation != "-")
        {
            Console.WriteLine("Invalid operation. Program terminated.");
            return;
        }


        Console.WriteLine("Enter the number of rows:");
        int rows = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number of columns:");
        int columns = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the elements of the first matrix(เว้นวรรค ตัวอย่าง:4 5 6):");
        double[,] matrix1 = ReadMatrix(rows, columns);

        Console.WriteLine("Enter the elements of the second matrix(เว้นวรรค ตัวอย่าง:4 5 6):");
        double[,] matrix2 = ReadMatrix(rows, columns);

        double[,] result = CalculateResult(operation, matrix1, matrix2);

        Console.WriteLine("Result:");
        PrintMatrix(result);
    }

    static double[,] ReadMatrix(int rows, int columns)
    {
        double[,] matrix = new double[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            string[] rowElements = Console.ReadLine().Split(' ');

            for (int j = 0; j < columns; j++)
            {
                matrix[i, j] = double.Parse(rowElements[j]);
            }
        }

        return matrix;
    }

    static double[,] CalculateResult(string operation, double[,] matrix1, double[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int columns = matrix1.GetLength(1);

        double[,] result = new double[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (operation == "+")
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
                else if (operation == "-")
                {
                    result[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }
        }

        return result;
    }

    static void PrintMatrix(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix[i, j].ToString("0.0") + " ");
            }

            Console.WriteLine();
        }
    }
    }
}

