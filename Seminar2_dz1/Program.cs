// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write ("Enter a three-digit number ");

int a = Convert.ToInt32(Console.ReadLine());

if (a > 99 & a < 1000)
{
    int b = (a % 100)/10;
    Console.WriteLine ($"Second digit is {b}");
}
else Console.WriteLine ("Error");