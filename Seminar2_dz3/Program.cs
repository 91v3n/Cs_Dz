// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write ("Enter the day number of the week ");

int a = Convert.ToInt32(Console.ReadLine());

if (a < 1 | a > 7) Console.WriteLine("Error");
else if (a == 7 | a == 6) Console.WriteLine("it's a day off");
else Console.WriteLine("it's not a day off");