/* Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12 */
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

Console.WriteLine($"Сумма элементов главной диагонали массива равна {FindSumOfTheElementsOfTheMainDiagonalOfTheArray(array)}");

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

int FindSumOfTheElementsOfTheMainDiagonalOfTheArray(int[,] InputArray)
{
    int sum = 0;
    for (int i = 0; i < InputArray.GetLength(0); i++)
    {
        for (int j = 0; j < InputArray.GetLength(1); j++)
        {
            if (i == j) { sum = sum + InputArray[i, j]; }
        }
    }
    return sum;
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