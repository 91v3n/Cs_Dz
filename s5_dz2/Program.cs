// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] CreateArray(int l, int x, int y)
{
    int[] A = new int[l];
    Random X = new Random();
    for (int i = 0; i < A.Length; i++)
    {
        A[i] = X.Next(x, y);
    }
    return A;
}

void PrintArray(int[] A)
{
    for (int i = 0; i < A.Length; i++) Console.Write ($"{A[i]} ");
    Console.WriteLine();
}

void SumOdd(int[] A)
{
    int c = 0;
    for (int i = 0; i < A.Length; i++)
    {
        if (A[i]%2 != 0) c += A[i];
    }
    Console.WriteLine ($"Sum of odd = {c}");
}

int[] A = CreateArray(10, -100, 100);
PrintArray(A);
SumOdd(A);