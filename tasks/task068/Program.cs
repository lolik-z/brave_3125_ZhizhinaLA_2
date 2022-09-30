// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
int Akkerman(int m, int n)
{
    int result = 0;
    if (m == 0) result = n + 1;
    if ((m > 0) && (n == 0)) result = Akkerman(m - 1, 1);
    if ((m > 0) && (n > 0)) result = Akkerman(m - 1, Akkerman(m, n - 1));
    return result;
}
int m = 3;
int n = 2;
Console.WriteLine($" M = {m}; N = {n} -> A({m},{n}) = " + Akkerman(m, n));