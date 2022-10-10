// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

int[,] Increase(int[,] A, int[,] B)
{
    int[,] C = new int[A.GetLength(0), B.GetLength(1)];
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < A.GetLength(1); j++)
        {
            for (int k = 0; k < B.GetLength(0); k++)
            {
                C[i,j] += A[i, k] * B[k, j];     
            }
        }
    }
    return C;
}

int[,] A = FillArray(3, 3);
PrintArray(A);

int[,] B = FillArray(3, 3);
PrintArray(B);

int[,] C = Increase(A, B);
PrintArray(C);