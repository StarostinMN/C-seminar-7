/* Дополнительная задача 2 (задача со звёздочкой): Вывести первые n строк треугольника Паскаля. Реализовать вывод в виде равнобедренного треугольника. */
Console.Clear();
Console.Write("Введите количество строк треугольника Паскаля: ");
int N = Convert.ToInt32(Console.ReadLine());

for (int n = 0; n < N; n++)
{
    int[] BinomKoef = new int[n + 1];

    PrintText(" ", N - n);
    for (int m = 0; m < n + 1; m++)
    {
        BinomKoef[m] = Factorial(n) / (Factorial(m) * Factorial(n - m));

        Console.Write($"{BinomKoef[m]} ");
    }
    Console.WriteLine();
}

int Factorial(int number)
{
    if (number == 1 || number == 0) return 1;

    return number * Factorial(number - 1);
}

void PrintText(string message, int count)
{
    for (int i = 0; i < count; i++)
    {
        Console.Write(message);
    }
}
