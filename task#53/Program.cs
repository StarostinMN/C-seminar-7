/* Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
Изначальный массив: 	
1 4 7 2
5 9 2 3
8 4 2 4
Итоговый массив: 	
8 4 2 4
5 9 2 3
1 4 7 2 */

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

int[,] fixedArray = FixArray(array);

PrintArray(array);
Console.WriteLine();
PrintArray(fixedArray);

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

int[,] FixArray(int[,] inputArray)
{
    int[,] fixedArray = new int[inputArray.GetLength(0), inputArray.GetLength(1)];
    for (int i = 1; i < inputArray.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            fixedArray[i, j] = inputArray[i, j];
        }
    }
    for (int j = 0; j < inputArray.GetLength(1); j++)
    {
        fixedArray[0, j] = inputArray[inputArray.GetLength(0) - 1, j];
        fixedArray[inputArray.GetLength(0) - 1, j] = inputArray[0, j];
    }
    return fixedArray;
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