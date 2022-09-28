// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
int[,] FillMasSpiral(int n)
{
    int[,] mas = new int[n, n];
    int temp = 1;
    for (int l = 0; l < n/2; l++)
    {
        for (int j = l; j < n - l; j++)
        {
            mas[l, j] = temp;
            temp++;
        }
        for (int i = l + 1; i < n - l; i++)
        {
            mas[i, n - l - 1] = temp;
            temp++;
        }       
        for (int j = n - l-1-1; j > l-1; j--)
        {
            mas[n - 1 - l, j] = temp;
            temp++;
        }       
        for (int i = n - l - 1-1; i > l; i--)
        {
            mas[i, l] = temp;
            temp++;
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
int[,] arr = FillMasSpiral(4);
PrintArray(arr);