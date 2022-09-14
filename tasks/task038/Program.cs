//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
using System;
using System.Globalization;
NumberFormatInfo nfi = new CultureInfo( "en-US", false ).NumberFormat;
nfi.NumberDecimalDigits = 2;
float[] FillArrayFloat(int size)
{
    float[] mas = new float[size];
    var rand = new Random();
    for (int i = 0; i < size; i++)
    {
        mas[i] =  (float)(rand.Next(-9, 10)+Math.Round(rand.NextDouble(),2));
    }
    return mas;
}
void PrintArray(float[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i != arr.Length - 1) Console.Write($"{arr[i].ToString( "N", nfi)}, ");
        else Console.WriteLine($"{arr[i].ToString( "N", nfi)}]");
    }
}
float DiffMaxMinArr(float[] arr)
{
    float max = arr[0]; 
    float min = arr[0]; 
    float diff = 0; 
    for (int i = 1; i < arr.Length; i++)
    {
        if (max < arr[i]) max = arr[i];
        if (min > arr[i]) min = arr[i];
   }
    diff=max-min;
    return diff;
}
try
{
System.Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());
float[] array = FillArrayFloat(size);
PrintArray(array);
float results = DiffMaxMinArr(array);
Console.WriteLine($"Разница между максимальным и минимальным элементов массива -> {results.ToString( "N", nfi)}");
}
catch
{
    Console.WriteLine("Что-то пошло не так!");
}