// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int even = 2;
while (even <= n) {
    Console.Write(even);
    Console.Write(" ");
    even = even + 2;
}