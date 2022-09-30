// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
//элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int SumRec(int M, int N)
{
    if (N < M) return 0;
    if (M == N) return N;
    return N + SumRec(M, N - 1);
}
int m = 1;
int n = 15;
Console.WriteLine($" M = {m}; N = {n} -> " + SumRec(m, n));