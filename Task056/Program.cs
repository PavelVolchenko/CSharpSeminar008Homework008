/*  Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
    которая будет находить строку с наименьшей суммой элементов.
    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    5 2 6 7
    Программа считает сумму элементов в каждой строке и выдаёт номер строки 
    с наименьшей суммой элементов: 1 строка                               */

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

void print2DArray(int[,] arrayToPrint)
{
    Console.Write(" \t");
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int findMinSumInArray(int[,] inputArray)
{
    // Сумма всех элементов
    int min = 0;
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            min += inputArray[i, j];
        }
    }

    // Находим сумму элементов в строке
    // Если она меньше min, присваиваем новое значение и запоминаем строку
    int result = 0;
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            sum += inputArray[i, j];
        }
        // Console.WriteLine($"Сумма {sum} строки {i}");
        if (sum < min)
        {
            min = sum;
            result = i + 1;
        }
    }
    return result;
}

Console.WriteLine("Задайте двумерный массив.");
Console.Write("Количество строк: ");
int height = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов: ");
int width = Convert.ToInt32(Console.ReadLine());

int[,] generateArray = generate2DArray(height, width, 1, 9);
print2DArray(generateArray);

int result = findMinSumInArray(generateArray);
Console.WriteLine($" -> {result} строка");
