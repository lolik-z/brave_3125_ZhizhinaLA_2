// Задача HARD SORT.
// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. 
//Отсортировать элементы по возрастанию слева направо и сверху вниз.
// Например, задан массив:
// 1 4 7 2
// 5 9 10 3
// После сортировки
// 1 2 3 4
// 5 7 9 10
int[,] FillMas(int n, int m) // Задали двумерный массив из целых чисел.
{
    int[,] mas = new int[n, m];
    for (int i = 0; i < n; i++)
    {

        for (int j = 0; j < m; j++)
        {
            mas[i, j] = new Random().Next(0, 11);
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
int[] GetSingleArray(int[,] arr) // Перевели двумерный массив в одномерный
{
            int[] m1 = new int[arr.GetLength(0) * arr.GetLength(1)];
            int z = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    m1[z] = arr[i, j];
                    z++;
                }
    return m1;
}
int[,] SingleToArray(int[] m1, int n, int m) // Перевели одномерный массив в двумерный с заданным колличеством строк и столбцов
{
            int[,] m2 = new int[n, m];
            int z = 0;
            for (int i = 0; i < n; i++)
            {
                // z = z + i;
                for (int j = 0; j < m; j++)
                {
                    // z = z + j;
                    m2[i, j] = m1[z];
                    z++;
                }
            }
                
    return m2;
}
int[] SelectionSortMin(int[] array) //Сортируем одномерный массив
{
    for (int i = 0; i < array.Length - 1; i++){
        int minPos = i;
        for (int j = i + 1; j < array.Length; j++){
            if (array[j] < array[minPos]) minPos = j;
        }
        int temp = array[i];
        array[i] = array[minPos];
        array[minPos] = temp;
    }
    return array;
}
try
{
    System.Console.WriteLine("Введите количество строк в массиве "); //Количество строк и столбцов задается с клавиатуры.
    int n = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите количество столбцов в массиве ");
    int m = Convert.ToInt32(Console.ReadLine());
    int[,] mas = FillMas(n, m);
    PrintArray(mas);
    
int[] singleArr = GetSingleArray(mas);
singleArr = SelectionSortMin(singleArr); //Сортируем одномерный массив
System.Console.WriteLine("");
PrintArray(SingleToArray(singleArr, mas.GetLength(0), mas.GetLength(1))); // Перевели одномерный массив в двумерный, напечатали 
}
catch
{
    Console.WriteLine("Что-то пошло не так!");
}
