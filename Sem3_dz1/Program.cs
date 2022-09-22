// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write ("Enter a five-digit number ");
int x = Convert.ToInt32 (Console.ReadLine());

if (x < 100000 & x > 9999)
{
    int a = x/10000%10;
    int b = x/1000%10;
    int c = x/10%10;
    int d = x%10;
    if (a == d & b == c) Console.Write ("Polindrome");
    else Console.Write ("Not polindrome");
}
else Console.Write ("Error");