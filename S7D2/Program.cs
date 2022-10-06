// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] FillArray()
{
    int[,] A = new int[4,4];
    Random X = new Random();
    for (int i = 0; i < A.GetLength(0); i++) for (int j = 0; j < A.GetLength(1); j++) A[i, j] = X.Next(10);
    return A;
}

void PrintArray(int[,] A)
{
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < A.GetLength(1); j++) Console.Write ($"{A[i, j]} ");
        Console.WriteLine();
    }
}

void FindElement (int[,] A, int i, int j)
{
    if (i < A.GetLength(0) & j < A.GetLength(1)) Console.WriteLine(A[i, j]);
    else Console.WriteLine("nothing");
}

Console.Write("Enter 1 position ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter 2 position ");
int j = Convert.ToInt32(Console.ReadLine());

int[,] A = FillArray();
PrintArray(A);
FindElement(A, i, j);