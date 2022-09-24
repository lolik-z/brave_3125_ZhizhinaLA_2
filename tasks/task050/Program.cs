// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента 
//или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
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
string ArrayElementSearch(int[,] arr, int n, int m)
{
    string str = string.Empty;
    if ((arr.GetLength(0) < n) ^ (arr.GetLength(1) < m))
    {
        str = "такого числа в массиве нет"; 
    }
    else str = arr[n, m].ToString();
    return str;
}
try
{
    System.Console.WriteLine("Введите два числа, позиции элемента в двумерном массиве ");
    int n = Convert.ToInt32(Console.ReadLine());
    int m = Convert.ToInt32(Console.ReadLine());
    int[,] mas = FillMas(3, 4);
    PrintArray(mas);
    System.Console.WriteLine();
    Console.WriteLine($"[{n},{m}] -> {ArrayElementSearch(mas,n,m)}");
}
catch
{
    Console.WriteLine("Что-то пошло не так!");
}
