/* Задача 50. Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

1,1 -> 9
1,7 -> элемента с данными индексами в массиве нет */
Console.Clear();

Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов двумерного массива");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимально возможное значение в двумерном массиве");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимально возможное значение в двумерном массиве");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = FillArray(rows, columns, min, max);

PrintArray(array);
Console.WriteLine();
GetElementOfArray(array);

int[,] FillArray(int ArrayRows, int ArrayColumns, int minValue, int maxValue)
{
    int[,] filledArray = new int[ArrayRows, ArrayColumns];
    Random random = new Random();
    for (int i = 0; i < ArrayRows; i++)
    {
        for (int j = 0; j < ArrayColumns; j++)
        {
            filledArray[i, j] = random.Next(minValue, maxValue + 1);
        }
    }
    return filledArray;
}

void PrintArray(int[,] inputArray)
{   
    Console.WriteLine("Сгенерированный массив:");
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int GetElementOfArray(int[,] InputArray)
{
    Console.Write("Введите номер строки требуемого элемента массива: ");
    int row = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите номер столбца требуемого элемента массива: ");
    int column = Convert.ToInt32(Console.ReadLine());

    if (row > InputArray.GetLength(0) || column > InputArray.GetLength(1))
    {
        Console.WriteLine($"Элемента с указанным индексом [{row}, {column}] в массиве нет");
        row = 0;
        column = 0;
    }
    else
    {
        Console.WriteLine($"Элемент с указанным индексом [{row}, {column}] равен {InputArray[row, column]}");
    }
    return InputArray[row, column];
}