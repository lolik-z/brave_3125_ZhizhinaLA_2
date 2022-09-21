// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)   x=(b2-b1)/(k1-k2) , y=k1(b2-b1)/(k1-k2)+b1
float[] IntersectionPoint(int b1, int k1, int b2, int k2)
{
    float[] mas = new float[2];
    mas[0] = (float)(b2 - b1) / (k1 - k2);
    mas[1] = (float)(k1 * (b2 - b1)) / (k1 - k2) + b1;
    return mas;
}
void PrintPoint(float[] arr)
{
    Console.Write("(");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i != arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.WriteLine($"{arr[i]})");
    }
}
try
{
    System.Console.WriteLine("Для поиска точки пересечения двух прямых y = k1 * x + b1, y = k2 * x + b2 задайте коэфициэнты b1, k1, b2, k2: ");
    int b1 = Convert.ToInt32(Console.ReadLine());
    int k1 = Convert.ToInt32(Console.ReadLine());
    int b2 = Convert.ToInt32(Console.ReadLine());
    int k2 = Convert.ToInt32(Console.ReadLine());
    if ((k1 == k2) && (b1 == b2)) System.Console.WriteLine("Прямые совпадают");
    else if ((k1 == k2) && (b1 != b2)) System.Console.WriteLine("Прямые параллельны");
    else
    {
        float[] Point1 = IntersectionPoint(b1, k1, b2, k2);
        Console.Write($"Точка пересечения прямых y = {k1} * x + {b1} и y = {k2} * x + {b2} это ");
        PrintPoint(Point1);
    }
}
catch
{
    Console.WriteLine("Что-то пошло не так!");
}
