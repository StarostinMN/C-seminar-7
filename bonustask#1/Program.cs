/* Дополнительная задача (задача со звёздочкой): Задайте двумерный массив из целых чисел. Определите, есть столбец в массиве, сумма которого, больше суммы элементов расположенных в четырех "углах" двумерного массива.

Например, задан массив:
4 4 7 5
4 3 5 3
8 1 6 8 -> нет

2 4 7 2
4 3 5 3
2 1 6 2 -> да */
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

//int[] SumArray = ComputeSumOfColumnsElements(array);
//Console.WriteLine($"Сумма элементов каждого столбца: {string.Join("; ", SumArray)}");

//int SumOFAngularElements = ComputeSumOfTheAngularElementsOfTheArray(array);
//Console.WriteLine($"Сумма угловых элементов массива: {SumOFAngularElements}");

IsColumnExist(ComputeSumOfColumnsElements(array), ComputeSumOfTheAngularElementsOfTheArray(array));

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

int[] ComputeSumOfColumnsElements(int[,] InputArray)
{
    int[] SumArray = new int[InputArray.GetLength(1)];
    for (int j = 0; j < InputArray.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < InputArray.GetLength(0); i++)
        {
            sum = sum + InputArray[i, j];
        }
        SumArray[j] = sum;
    }
    return SumArray;
}

int ComputeSumOfTheAngularElementsOfTheArray(int[,] InputArray)
{
    int sumOfAngular = 0;
    sumOfAngular = InputArray[0, 0] + InputArray[0, InputArray.GetLength(1) - 1] + InputArray[InputArray.GetLength(0) - 1, 0] + InputArray[InputArray.GetLength(0) - 1, InputArray.GetLength(1) - 1];
    return sumOfAngular;
}

void IsColumnExist(int[] sumOfColumnsElements, int sumOfAngularElements)
{
    int max = sumOfColumnsElements[0];
    for (int i = 1; i < sumOfColumnsElements.Length; i++)
    {
        if (sumOfColumnsElements[i] > max) { max = sumOfColumnsElements[i];}
    }
    if (max>sumOfAngularElements)
    {
        Console.WriteLine("Столбец, в котором сумма элементов больше суммы угловых элементов массива, в данном массиве существует");
    }
    else
    {
        Console.WriteLine("Столбца, в котором сумма элементов больше суммы угловых элементов массива, в данном массиве не существует");
    }
}

