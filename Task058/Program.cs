/*  Задача 58: Задайте две матрицы. Напишите программу, которая 
    будет находить произведение двух матриц.
    Например, даны 2 матрицы:
    2 4 | 3 4
    3 2 | 3 3
    Результирующая матрица будет:
    18 20
    15 18                                                     */

int[,] generate2DArray(int height, int width, int randomStart, int randomEnd)
{
    int[,] twoDArray = new int[height, width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            twoDArray[i, j] = new Random().Next(randomStart, randomEnd + 1);
        }
    }
    return twoDArray;
}

void printColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(data);
    Console.ResetColor();
}

void print2DArray(int[,] arrayToPrint)
{
    Console.WriteLine();
    Console.Write(" \t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        printColorData(i + "\t");
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        printColorData(i + "\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] multiplicationMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] result = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    int multi;
    for (int i = 0; i < firstMatrix.GetLength(0); ++i)
    {
        for (int k = 0; k < secondMatrix.GetLength(1); k++)
        {
            multi = 0;
            for (int j = 0; j < firstMatrix.GetLength(1); ++j)
            {
                multi += firstMatrix[i, j] * secondMatrix[j, k];
            }
            result[i, k] = multi;
        }
    }
    return result;
}

Console.WriteLine("Задайте двумерный массив для двух матриц.");
Console.Write("Количество строк: ");
int height = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов: ");
int width = Convert.ToInt32(Console.ReadLine());

int[,] firstMatrix = generate2DArray(height, width, 1, 9);
print2DArray(firstMatrix);
int[,] secondMatrix = generate2DArray(height, width, 1, 9);
print2DArray(secondMatrix);

int[,] result = multiplicationMatrix(firstMatrix, secondMatrix);
Console.WriteLine("\nРезультирующая матрица будет:");
print2DArray(result);