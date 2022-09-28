// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
int[,] FillMas(int n, int m)
{
    int[,] mas = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            mas[i, j] = new Random().Next(0, 10);
        }
    }
    return mas;
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j != arr.GetLength(1) - 1) Console.Write($"{arr[i, j]}, ");
            else if (i == arr.GetLength(0) - 1 && j == arr.GetLength(1) - 1) Console.WriteLine($"{arr[i, j]}");
            else if (j == arr.GetLength(1) - 1) Console.WriteLine($"{arr[i, j]},");
        }
    }
}
int[,] MultArray(int[,] a, int[,] b)
{
    int[,] r = new int[a.GetLength(0), b.GetLength(1)];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int k = 0; k < b.GetLength(0); k++)
            {
                r[i, j] += a[i, k] * b[k, j];
            }
        }
    }
    return r;
}
try
{
    Console.WriteLine("Матрицы A и B могут быть перемножены, если число столбцов матрицы A равно числу строк B.");
    Console.WriteLine("Введите количество строк в массиве A ");
    int n1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов в массиве A");
    int m1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество строк в массиве Б ");
    int n2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов в массиве Б");
    int m2 = Convert.ToInt32(Console.ReadLine());
    if (m1 != n2) Console.WriteLine("Матрицы нельзя перемножить");
    else
    {
        int[,] mas1 = FillMas(n1, m1);
        PrintArray(mas1);
        Console.WriteLine();
        int[,] mas2 = FillMas(n2, m2);
        PrintArray(mas2);
        Console.WriteLine();
        PrintArray(MultArray(mas1, mas2));
    }
}
catch
{
    Console.WriteLine("Что-то пошло не так!");
}
