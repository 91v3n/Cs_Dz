// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] FillArray(int m, int n, int l)
{
    int[,,] A = new int[m, n, l];
    Random X = new Random();
    for (int i = 0; i < A.GetLength(0); i++) 
    for (int j = 0; j < A.GetLength(1); j++)
    for (int k = 0; k < A.GetLength(2); k++)
    A[i, j, k] = X.Next(70) + i*j*k;
    return A;
}

void PrintArray(int[,,] A)
{
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < A.GetLength(1); j++)
        {
        for (int k = 0; k < A.GetLength(1); k++)
        {
        Console.Write ($"{A[i, j, k]}({i},{j},{k}) ");
        }
        Console.WriteLine();
        }
    Console.WriteLine();
    }
}

PrintArray(FillArray(3,3,3));