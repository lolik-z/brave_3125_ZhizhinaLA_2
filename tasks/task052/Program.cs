// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int[,] FillMas(int n, int m)
{
    int[,] mas = new int[n, m];
    for (int i = 0; i < n; i++)
    {

        for (int j = 0; j < m; j++)
        {
            mas[i, j] = new Random().Next(-10, 11);
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
float[] ArrayAverage(int[,] arr)
{
    float[] mas = new float[arr.GetLength(1)];
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        int summ = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            summ = summ + arr[i, j];
        }
        mas[j] = (float)summ / arr.GetLength(0);
    }
    return mas;
}
try
{
    System.Console.WriteLine("Введите количество строк в массиве ");
    int n = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите количество столбцов в массиве ");
    int m = Convert.ToInt32(Console.ReadLine());
    int[,] mas = FillMas(n, m);
    PrintArray(mas);
    float[] masAverage = ArrayAverage(mas);
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < m-1; i++)
    {
        Console.Write($"{masAverage[i]}; ");
    }
    System.Console.WriteLine($"{masAverage[m-1]}");
}
catch
{
    Console.WriteLine("Что-то пошло не так!");
}
