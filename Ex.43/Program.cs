﻿//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



Console.Write("Введите первое число ");
string str1 = Console.ReadLine();
double b1 = double.Parse(str1);
Console.Write("Введите второе число ");
string str2 = Console.ReadLine();
double k1 = double.Parse(str2);
Console.Write("Введите третье число ");
string str3 = Console.ReadLine();
double b2 = double.Parse(str3);
Console.Write("Введите четвёртое число ");
string str4 = Console.ReadLine();
double k2 = double.Parse(str4);
double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
Console.WriteLine($"Точка пересечения двух прямых: ({x};{y})");