// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
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
int[,] SortArray(int[,] array) //Упорядочиваем по убыванию элементы каждой строки двумерного массива
{
    for (int k = 0; k < array.GetLength(0); k++)
    {
        for (int i = 0; i < array.GetLength(1) - 1; i++)
        {
            int minPos = i;
            for (int j = i + 1; j < array.GetLength(1); j++)
            {
                if (array[k, j] > array[k, minPos]) minPos = j;
            }
            int temp = array[k, i];
            array[k, i] = array[k, minPos];
            array[k, minPos] = temp;
        }
    }
    return array;
}
try
{
    System.Console.WriteLine("Введите количество строк в массиве ");
    int n = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите количество столбцов в массиве ");
    int m = Convert.ToInt32(Console.ReadLine());
    int[,] mas = FillMas(n, m);
    PrintArray(mas);
    System.Console.WriteLine();
    PrintArray(SortArray(mas));  
}
catch
{
    Console.WriteLine("Что-то пошло не так!");
}