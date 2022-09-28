// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
int[,] FillMas(int n, int m) // Задали двумерный массив из целых чисел.
{
    int[,] mas = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            mas[i, j] = new Random().Next(0, 11);
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
int MinSamStringArray(int[,] array)
{
    int[] mas = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            mas[i] = mas[i] + array[i, j];
        }
    }
    int minStr = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i] < mas[minStr]) minStr = i;        
    }
    return minStr+1;
}
try
{
    int[,] mas = FillMas(4, 4);
    PrintArray(mas);
    System.Console.WriteLine();
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {MinSamStringArray(mas)} строка");
}
catch
{
    Console.WriteLine("Что-то пошло не так!");
}