// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int[] FillArray3(int size)
{
    int[] mas = new int[size];

    for (int i = 0; i < size; i++)
    {
        mas[i] = new Random().Next(100, 1000);
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
int QuantityEven(int[] arr)
{
    int qeven = 0;    
    foreach (int item in arr)
    {
        if (item%2 == 0) qeven++;        
    }
    return qeven;
}
try
{
System.Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array3 = FillArray3(size);
PrintArray(array3);
int results = QuantityEven(array3);
Console.WriteLine($"Количество чётных чисел в массиве -> {results}");
}
catch
{
    Console.WriteLine("Что-то пошло не так!");
}