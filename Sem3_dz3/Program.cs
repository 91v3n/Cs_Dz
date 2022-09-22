// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write ("Enter number ");
int x = Convert.ToInt32 (Console.ReadLine());

for (int i = 1; i <= x; i++) Console.Write ($"{Math.Pow (i, 3)} ");