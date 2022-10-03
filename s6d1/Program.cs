// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] EnterArray()
{
    Console.WriteLine ("How many numbers do you want to enter?");
    int M = Convert.ToInt32(Console.ReadLine());
    int[] A = new int[M];
    Console.WriteLine ($"Enter {M} numbers");
    for (int i = 0; i < A.Length; i++) A[i] = Convert.ToInt32(Console.ReadLine());
    return A;
}

void PrintArray(int[] A)
{
    for (int i = 0; i < A.Length; i++) Console.Write($"{A[i]} ");
    Console.WriteLine();
}

void Count(int[] A)
{
    int c = 0;
    for (int i = 0; i < A.Length; i++) 
    {
        if (A[i] > 0) c++;
    }
    Console.WriteLine($"Quantity greater then zero = {c}");
}

int[] A = EnterArray();
PrintArray(A);
Count(A);