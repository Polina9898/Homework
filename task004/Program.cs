﻿// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите 1-ое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3-ие число: ");
int c = Convert.ToInt32(Console.ReadLine());

if ((a >= b) && (a >= c)) {
    Console.Write("max = ");
    Console.WriteLine(a);
} 
else if ((b >= a) && (b >= c)) {
    Console.Write("max = ");
    Console.WriteLine(b);
}

else if ((c >= a) && (c >= b)) {
    Console.Write("max = ");
    Console.Write(c);
}