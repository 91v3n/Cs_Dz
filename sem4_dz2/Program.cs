// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write ("Enter number ");
int A = Convert.ToInt32(Console.ReadLine());
int F = 0;
while (A > 0) {F = A % 10 + F; A /= 10;}
Console.WriteLine ($"Sum of digits = {F}");