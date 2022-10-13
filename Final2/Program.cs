// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int Sum(int m, int n) {if (m == n) return n; return m + Sum(m + 1, n);}

Console.WriteLine(Sum (5, 10));