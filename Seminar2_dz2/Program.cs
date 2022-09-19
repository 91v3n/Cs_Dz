// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write ("Enter number ");

int a = Convert.ToInt32(Console.ReadLine());

if (a < 100) 
    Console.WriteLine ("There is no third digit in the number");
else
{
    while (a > 999)
        a/=10;
    int b = a % 10;
    Console.WriteLine ($"Third digit is {b}");
}