// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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
}

void StringSum(int[,] A)
{
    int sum = 0;
    int res = 1000000;
    int str = 0;
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < A.GetLength(1); j++) sum += A[i, j];
        if (res > sum) 
        {
            res = sum;
            str = i+1;
        }
        sum = 0;
    }
    Console.WriteLine ($"Min sum = {res} in string {str}");
}

int[,] A = FillArray(6, 3);
PrintArray(A);
StringSum(A);