/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */
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
double[] AveragesArray = ComputeAverageOfColumnsElements(array);
Console.WriteLine($"Среднее арифметическое каждого столбца: {string.Join("; ", AveragesArray)}");

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
    Console.WriteLine("Сгенерирован массив:");
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i, j] + "    ");
        }
        Console.WriteLine();
    }
}

double[] ComputeAverageOfColumnsElements (int[,] InputArray)
{   double[] AverageArray = new double[InputArray.GetLength(1)];
    for (int j = 0; j < InputArray.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < InputArray.GetLength(0); i++)
        {
            sum = sum + InputArray[i, j];
        }
        AverageArray[j] = Math.Round((double)sum / InputArray.GetLength(0), 2);
    }
    return AverageArray;
}


