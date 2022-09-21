int[] FillArray(int size)
{
    int[] mas = new int[size];
    System.Console.WriteLine($"Введите {size} чисел");
    for (int i = 0; i < size; i++)
    {
    mas[i] = Convert.ToInt32(Console.ReadLine());
    }
    return mas;
}
int AboveZero(int[] arr)
{
    int number = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]>0) number = number + 1;        
    }
    return number;
}
try
{
System.Console.Write("Сколько чисел будем анализировать? - ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(size);
Console.WriteLine($"Введено чисел больше нуля: {AboveZero(array)}");
}
catch
{
    Console.WriteLine("Что-то пошло не так!");
}
