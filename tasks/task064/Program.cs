// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа
// в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
string SeriesOfNumbers(int N)
{
    if (N == 0) return String.Empty;
    return Convert.ToString(N) + " " + SeriesOfNumbers(N -1);
}
int n = 8;
Console.WriteLine($" N = {n} -> " + SeriesOfNumbers(n));