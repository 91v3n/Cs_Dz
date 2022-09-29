// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

void Fx(int[] M)
{
    Random X = new Random();
    int c = 0;
    for (int i = 0; i < M.Length; i++)
    {
        M[i] = X.Next(100, 1000);
        Console.Write ($"{M[i]} ");
        if (M[i]%2 == 0) c++;
    }
    Console.WriteLine ($"Number of even = {c}");
}

int[] M = new int[10];

Fx(M);