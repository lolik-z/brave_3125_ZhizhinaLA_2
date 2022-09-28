// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
int[,,] FillMas3(int n, int m, int r)
{
    int[] tempMas = new int[n*m*r];
  int  number;
  for (int i = 0; i < tempMas.Length; i++)
  {
    tempMas[i] = new Random().Next(10, 100);
    number = tempMas[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (tempMas[i] == tempMas[j])
        {
          tempMas[i] = new Random().Next(10, 100);
          j = 0;
          number = tempMas[i];
        }
          number = tempMas[i];
      }
    }
  }
    int[,,] mas = new int[n, m, r];
    int count = 0; 
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            for (int k = 0; k < m; k++)
            {
                mas[i, j, k] = tempMas[count];
                count++;
            }
        }
    }
    return mas;
}
void PrintArray3(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[j, k, i]}({j},{k},{i}) ");
            }
            Console.WriteLine();
        }
    }
}
int[,,] arr = FillMas3(2, 2, 2);
PrintArray3(arr);