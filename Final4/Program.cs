// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

void Numbers(int n)
{
    if (n > 0)
    {
        Console.Write($"{n} ");
        n--;
        Numbers(n);
    }
}

Numbers(Convert.ToInt32(Console.ReadLine()));