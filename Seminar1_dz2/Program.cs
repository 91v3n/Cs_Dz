//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Enter fitrst number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter third number: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b)
    if (a > c)
        Console.WriteLine($"Larger number {a}");
    else
        Console.WriteLine($"Larger number {c}");
else
    if (b > c)
        Console.WriteLine($"Larger number {b}");
    else
        Console.WriteLine($"Larger number {c}");