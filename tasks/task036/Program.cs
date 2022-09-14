// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int[] FillArray(int size)
{
    int[] mas = new int[size];

    for (int i = 0; i < size; i++)
    {
        mas[i] = new Random().Next(-99, 100);
    }
    return mas;
}
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i != arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.WriteLine($"{arr[i]}]");
    }
}
int SumOdd(int[] arr)
{
    int qeven = 0;
    int i = 1;    
    while ( i < arr.Length)
    {
        qeven=qeven + arr[i];
        i = i + 2;
    }
    return qeven;
}
try
{
System.Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(size);
PrintArray(array);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях -> {SumOdd(array)}");
}
catch
{
    Console.WriteLine("Что-то пошло не так!");
}