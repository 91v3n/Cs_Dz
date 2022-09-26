// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine ("Enter 2 numbers");
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
int F = A;
for (int i = 1; i < B; i++) F *= A;
Console.WriteLine ($"{A} to the power of {B} is equal to {F}");