﻿// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n % 2 == 0)
Console.Write("yes");
else
Console.Write("no");
