/* Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5 */
Console.Clear();

Console.WriteLine("Введите требуемое количество строк двумерного массива");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите требуемое количество столбцов двумерного массива");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

PrintArray(FillArray(m, n));

int[,] FillArray(int ArrayRows, int ArrayColumns)
{
    int[,] filledArray = new int[ArrayRows, ArrayColumns];
    for (int i = 0; i < ArrayRows; i++)
    {
        for (int j = 0; j < ArrayColumns; j++)
        {
            filledArray[i, j] = i + j;
        }
    }
    return filledArray;
}

void PrintArray(int[,] InputArray)
{
    for (int i = 0; i < InputArray.GetLength(0); i++)
    {
        for (int j = 0; j < InputArray.GetLength(1); j++)
        {
            Console.Write(InputArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}
