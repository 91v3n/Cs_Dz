// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine ("Enter first coordinate (x, y, z)");
int[] A = {Convert.ToInt16(Console.ReadLine()), Convert.ToInt16(Console.ReadLine()), Convert.ToInt16(Console.ReadLine())};

Console.WriteLine ("Enter second coordinate (x, y, z)");
int[] B = {Convert.ToInt16(Console.ReadLine()), Convert.ToInt16(Console.ReadLine()), Convert.ToInt16(Console.ReadLine())};

Console.WriteLine ($"Distance = {Math.Sqrt(Math.Pow(B[0]-A[0],2)+Math.Pow(B[1]-A[1],2)+Math.Pow(B[2]-A[2],2))}");