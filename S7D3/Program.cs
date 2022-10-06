// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

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

void Average(int[,] A)
{
    double sum;
    for (int j = 0; j < A.GetLength(1); j++)
    {
        sum = 0;
        for (int i = 0; i < A.GetLength(0); i++) sum += A[i, j];
        Console.Write($"{sum/A.GetLength(0)} ");
    }
}

int[,] A = FillArray();
PrintArray(A);
Average(A);