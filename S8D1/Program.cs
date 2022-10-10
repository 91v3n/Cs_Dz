// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] FillArray(int m, int n)
{
    int[,] A = new int[m, n];
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
    Console.WriteLine();
}

int[,] Regulate(int[,] A)
{
    int temp;
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int c = 0; c < A.GetLength(1); c++)
        {
            for (int j = 0; j < A.GetLength(1)-1; j++)
            {
                if (A[i,j] > A[i,j+1])
                {
                    temp = A[i,j];
                    A[i,j] = A[i,j+1];
                    A[i,j+1] = temp;
                }
            }
        }
    }
    return A;
}

int[,] A = FillArray(5, 5);
PrintArray(A);
int[,] B = Regulate(A);
PrintArray(A);