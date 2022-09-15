//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Enter fitrst number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a == b)
    Console.WriteLine("Numbers are equal");
else
    if (a < b)
        Console.WriteLine($"Larger number - {b} | Smaller number {a}");
    else
        Console.WriteLine($"Larger number - {a} | Smaller number {b}");
