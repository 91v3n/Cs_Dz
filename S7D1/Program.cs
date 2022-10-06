// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. m = 3, n = 4.

double[,] FillArray(int m, int n)
{
    double[,] A = new double[m, n];
    Random X = new Random();
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < A.GetLength(1); j++)
        {
            A[i, j] = Math.Round(X.NextDouble()*20-10, 1);
        }
    }
    return A;
}

void PrintArray(double[,] A)
{
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < A.GetLength(1); j++)
        {
            Console.Write ($"{A[i, j]} ");
        }
        Console.WriteLine();
    }   
}

PrintArray(FillArray(13, 7));