// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] FillArray()
{
    int[,] A = new int[4,4];
    int x = 1;
    int i = 0;
    int j = 0;
    while (j < 3) {A[i, j] = x++; j++;} j=3;
    while (i < 3) {A[i, j] = x++; i++;} i=3;
    while (j > 0) {A[i, j] = x++; j--;} j=0;
    while (i > 1 ) {A[i, j] = x++; i--;} i=1;
    while (j < 2) {A[i, j] = x++; j++;} j=2;
    while (i < 2) {A[i, j] = x++; i++;} i=2;
    while (j > 1) {A[i, j] = x++; j--;} j=1;
    while (i > 1 ) {A[i, j] = x++; i--;} i=1;
    return A;
}

void PrintArray(int[,] A)
{
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < A.GetLength(1); j++) Console.Write ($"{A[i, j].ToString().PadLeft(2, '0')} ");
        Console.WriteLine();
    }
}

int[,] A = FillArray();
PrintArray(A);