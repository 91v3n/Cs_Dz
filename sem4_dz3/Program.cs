// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] M = new int[8];
Random X = new Random();
for (int i = 0; i < M.Length; i++)
{
    M[i] = X.Next(100);
    Console.Write ($"{M[i]} ");
}

// Вариант с ручным заполнением
// for (int i = 0; i < M.Length; i++) M[i] = Convert.ToInt32(Console.ReadLine());
// for (int i = 0; i < M.Length; i++) Console.Write ($"{M[i]} ");