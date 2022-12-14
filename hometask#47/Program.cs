/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9 */

Console.Clear();

Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов двумерного массива");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимально возможное значение в двумерном массиве (будет округлено до целого)");
int min = (int)Math.Round(Convert.ToDouble(Console.ReadLine()), 0);

Console.WriteLine("Введите максимально возможное значение в двумерном массиве (будет округлено до целого)");
int max = (int)Math.Round(Convert.ToDouble(Console.ReadLine()), 0);

double[,] array = FillArray(rows, columns, min, max);

PrintArray(array);

double[,] FillArray(int ArrayRows, int ArrayColumns, int minValue, int maxValue)
{
    double[,] filledArray = new double[ArrayRows, ArrayColumns];
    Random random = new Random();
    for (int i = 0; i < ArrayRows; i++)
    {
        for (int j = 0; j < ArrayColumns; j++)
        {
            filledArray[i, j] = Math.Round(random.Next(minValue, maxValue + 1) / Math.PI*3, 1);
        }
    }
    return filledArray;
}

void PrintArray(double[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i, j] + "  ");
        }
        Console.WriteLine();
    }
}