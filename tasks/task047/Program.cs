// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
using System;
using System.Globalization;
NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
nfi.NumberDecimalDigits = 1;
float[,] FillArrayFloat2(int n, int m)
{
    float[,] mas = new float[n, m];
    var rand = new Random();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            mas[i, j] = (float)(rand.Next(-9, 10) + Math.Round(rand.NextDouble(), 1));
        }
    }
    return mas;
}
void PrintArray2(float[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j != arr.GetLength(1) - 1)
                Console.Write($"{arr[i, j].ToString("N", nfi)}, ");
            else if (i == arr.GetLength(0) - 1 && j == arr.GetLength(1) - 1)
                Console.WriteLine($"{arr[i, j].ToString("N", nfi)}");
            else if (j == arr.GetLength(1) - 1)
                Console.WriteLine($"{arr[i, j].ToString("N", nfi)},");
        }
    }
}
float[,] arr = FillArrayFloat2(3, 4);
PrintArray2(arr);