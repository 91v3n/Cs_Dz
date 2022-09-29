// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateArray()
{
    double[] A = new double[10];
    Random X = new Random();
    for (int i = 0; i < A.Length; i++)
    {
        A[i] = Math.Round(X.NextDouble()*100, 2);
    }
    return A;
}

void PrintArray(double[] A)
{
    for (int i = 0; i < A.Length; i++) Console.Write ($"{A[i]} ");
    Console.WriteLine();
}

void Difference(double[] A)
{
    double min = A[0];
    double max = A[0];
    int i = 0;
    while (i < A.Length)
    {
        if (A[i] < min) min = A[i];
        if (A[i] > max) max = A[i];
        i++;
    }
    Console.WriteLine ($"Difference max-min {Math.Round(max-min, 2)}");
}

double[] A = CreateArray();
PrintArray(A);
Difference(A);