﻿// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


double FindDistans()
{
Console.WriteLine("Введите координаты точки А по x: ");
double Ax = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты точки А по y: ");
double Ay = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты точки А по z: ");
double Az = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты точки B по x: ");
double Bx = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты точки B по y: ");
double By = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты точки B по z: ");
double Bz = double.Parse(Console.ReadLine());
double distanse = Math.Sqrt(Math.Pow(Bx - Ax, 2) + Math.Pow(By - Ay, 2) + Math.Pow(Bz - Az, 2));
return distanse;
}
double distanse = FindDistans();
Console.WriteLine($"Растояние между точкой А и точкой В = "+distanse); 
