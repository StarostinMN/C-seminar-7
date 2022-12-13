/* Демонстрация решения
Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1
 */
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
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}