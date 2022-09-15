// Задача HARD STAT необязательная: Задайте массив случайных целых чисел. Найдите максимальный элемент и его индекс, 
// минимальный элемент и его индекс, среднее арифметическое всех элементов. Сохранить эту инфу в отдельный массив и 
// вывести на экран с пояснениями. 
// Найти медианное значение , возможно придется кое-что для этого дополнительно выполнить.
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
float[] СountForArray(int[] arr)
{
    float[] masReturn = new float[6];
    int max = arr[0];
    int min = arr[0];
    int indexMax = 0;
    int indexMin = 0;
    int sum = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (max < arr[i])
        {
            max = arr[i];
            indexMax = i;
        }
        if (min > arr[i])
        {
            min = arr[i];
            indexMin = i;
        }
        sum = sum + arr[i];
    }    
    masReturn[0] = max;
    masReturn[1] = indexMax;
    masReturn[2] = min;
    masReturn[3] = indexMin;
    masReturn[4] = (float)sum/arr.Length;
    if (arr.Length%2==0) masReturn[5] = (arr[arr.Length/2-1] + arr[arr.Length/2])/2;
    else masReturn[5] = arr[arr.Length/2];
    return masReturn;
}
try
{
    System.Console.WriteLine("Введите размерность массива");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = FillArray(size);
    PrintArray(array);
    float[] results = СountForArray(array);
    Console.WriteLine($"Максимальный элемент и его индекс -> {results[0]} и {results[1]}");
    Console.WriteLine($"Минимальный элемент и его индекс -> {results[2]} и {results[3]}");
    Console.WriteLine($"Среднее арифметическое всех элементов -> {results[4].ToString("N")}");
    Console.WriteLine($"Медианное значение элементов массива -> {results[5]}");
}
catch
{
    Console.WriteLine("Что-то пошло не так!");
}
