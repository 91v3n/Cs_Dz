// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Enter k1, k2, b1, b2");

double k1 = Convert.ToDouble(Console.ReadLine());
double k2 = Convert.ToDouble(Console.ReadLine());
double b1 = Convert.ToDouble(Console.ReadLine());
double b2 = Convert.ToDouble(Console.ReadLine());

double x = (b1-b2) / (k2-k1);
double y = k1 * x + b1;

Console.WriteLine($"Points of intersection of lines = ({x}, {y})");

